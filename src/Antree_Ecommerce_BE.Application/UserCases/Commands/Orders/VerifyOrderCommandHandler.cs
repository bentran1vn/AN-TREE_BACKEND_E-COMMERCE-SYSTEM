using System.Globalization;
using Antree_Ecommerce_BE.Application.Abstractions;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Orders;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Query = Antree_Ecommerce_BE.Contract.Services.Products.Query;

namespace Antree_Ecommerce_BE.Application.UserCases.Commands.Orders;

public class VerifyOrderCommandHandler : ICommandHandler<Command.VerifyOrderCommand>
{
    private readonly IRepositoryBase<Order, Guid> _orderRepository;
    private readonly IVnPayService _vnPayService;
    private readonly IRepositoryBase<OrderDetail, Guid> _orderDetailRepository;
    private readonly IRepositoryBase<Product, Guid> _productRepository;
    private readonly ICacheService _cacheService;

    public VerifyOrderCommandHandler(IRepositoryBase<Order, Guid> orderRepository, IVnPayService vnPayService, IRepositoryBase<OrderDetail, Guid> orderDetailRepository, IRepositoryBase<Product, Guid> productRepository, ICacheService cacheService)
    {
        _orderRepository = orderRepository;
        _vnPayService = vnPayService;
        _orderDetailRepository = orderDetailRepository;
        _productRepository = productRepository;
        _cacheService = cacheService;
    }

    public async Task<Result> Handle(Command.VerifyOrderCommand request, CancellationToken cancellationToken)
    {
        var (valid, message) = await _vnPayService.ValidateCallback(request.vnpayData);
        var order = await _orderRepository.FindByIdAsync(new Guid(request.vnpayData["vnp_TxnRef"]), cancellationToken);
        if (!valid)
        {
            order.Status= 1;
            var orderDetails = await _orderDetailRepository
                .FindAll(x => x.OrderId.Equals(order.Id)).ToDictionaryAsync(x => x.ProductId, cancellationToken);

            var product = await _productRepository.FindAll(x => orderDetails.Keys.Contains(x.Id)).ToListAsync(cancellationToken);
            foreach (var pro in product)
            {
                pro.Sku += orderDetails[pro.Id].ProductQuantity;
                pro.Sold -= orderDetails[pro.Id].ProductQuantity;
            }
            await _cacheService.RemoveByPrefixAsync($"{nameof(Query.GetProductsQuery)}", cancellationToken);
        }
        else
        {
            order.Status= 2;
        }
        return Result.Success(message);
    }
}