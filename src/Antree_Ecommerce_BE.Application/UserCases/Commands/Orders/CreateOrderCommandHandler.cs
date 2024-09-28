using Antree_Ecommerce_BE.Application.Abstractions;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Orders;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Antree_Ecommerce_BE.Application.UserCases.Commands.Orders;

public class CreateOrderCommandHandler : ICommandHandler<Command.CreateOrderCommand>
{
    private readonly IVnPayService _vnPayService;
    private readonly IRepositoryBase<Order, Guid> _orderRepository;
    private readonly IRepositoryBase<OrderDetail, Guid> _orderDetailRepository;
    private readonly IRepositoryBase<Product, Guid> _productRepository;

    public CreateOrderCommandHandler(IVnPayService vnPayService, IRepositoryBase<Order, Guid> orderRepository, IRepositoryBase<OrderDetail, Guid> orderDetailRepository, IRepositoryBase<Product, Guid> productRepository)
    {
        _vnPayService = vnPayService;
        _orderRepository = orderRepository;
        _orderDetailRepository = orderDetailRepository;
        _productRepository = productRepository;
    }

    public async Task<Result> Handle(Command.CreateOrderCommand request, CancellationToken cancellationToken)
    {
        var productIds = request.OrderItems.Select(orderItem => orderItem.ProductId).ToHashSet();
        
        var products = await _productRepository.FindAll(x => productIds.Contains(x.Id) && !x.IsDeleted)
            .ToDictionaryAsync(x => x.Id, cancellationToken);

        if (productIds.Count != products.Count)
            return Result.Failure(new Error("500","Some products in your order are not available."));

        var total = 0m;
        var updatedProducts = new List<Product>();

        foreach (var orderItem in request.OrderItems)
        {
            var product = products[orderItem.ProductId];
            if (product.Sku < orderItem.Quantity)
                return Result.Failure(new Error("400", $"Insufficient stock for product: {product.Name}"));

            product.Sku -= orderItem.Quantity;
            product.Sold += orderItem.Quantity;
            total += orderItem.Quantity * product.DiscountSold;
            updatedProducts.Add(product);
        }
        
        var order = new Order
        {
            Id = Guid.NewGuid(),
            Address = string.Empty,
            Note = string.Empty,
            Total = total,
            UserId = request.UserId ?? new Guid(), // Consider setting this to the actual user ID
            Status = 0,
        };
        
        _orderRepository.Add(order);

        var orderDetails = request.OrderItems.Select(x => new OrderDetail
        {
            Id = Guid.NewGuid(),
            ProductId = x.ProductId,
            OrderId = order.Id,
            ProductQuantity = x.Quantity,
            ProductPrice = products[x.ProductId].Price,
            ProductPriceDiscount = products[x.ProductId].DiscountSold,
        }).ToList();
        
        _orderDetailRepository.AddRange(orderDetails);
        _productRepository.UpdateRange(updatedProducts);
        
        string url = _vnPayService.CreatePaymentUrl(order);
        
        return Result.Success(url);
    }
}