using Antree_Ecommerce_BE.Application.Abstractions;
using Antree_Ecommerce_BE.Application.SignalR;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Orders;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Query = Antree_Ecommerce_BE.Contract.Services.Products.Query;

namespace Antree_Ecommerce_BE.Application.UserCases.Commands.Orders;

public class CreateOrderCommandHandler : ICommandHandler<Command.CreateOrderCommand>
{
    private readonly IVnPayService _vnPayService;
    private readonly IRepositoryBase<Order, Guid> _orderRepository;
    private readonly IRepositoryBase<OrderDetail, Guid> _orderDetailRepository;
    private readonly IRepositoryBase<Product, Guid> _productRepository;
    private readonly ICacheService _cacheService;
    private readonly PaymentService _paymentService;
    private readonly IRepositoryBase<Domain.Entities.UserAddress, Guid> _userAddressRepository;
    private readonly IRepositoryBase<Domain.Entities.User, Guid> _userRepository;


    public CreateOrderCommandHandler(IVnPayService vnPayService, IRepositoryBase<Order, Guid> orderRepository, IRepositoryBase<OrderDetail, Guid> orderDetailRepository, IRepositoryBase<Product, Guid> productRepository, ICacheService cacheService, PaymentService paymentService, IRepositoryBase<Domain.Entities.UserAddress, Guid> userAddressRepository, IRepositoryBase<User, Guid> userRepository)
    {
        _vnPayService = vnPayService;
        _orderRepository = orderRepository;
        _orderDetailRepository = orderDetailRepository;
        _productRepository = productRepository;
        _cacheService = cacheService;
        _paymentService = paymentService;
        _userAddressRepository = userAddressRepository;
        _userRepository = userRepository;
    }

    public async Task<Result> Handle(Command.CreateOrderCommand request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.FindByIdAsync(request.UserId, cancellationToken);

        if (user is null)
        {
            return Result.Failure(new Error("404", "User not Existed !"));
        }

        var userAddress =
            await _userAddressRepository.FindSingleAsync(x =>
                x.UserId.Equals(request.UserId) && !x.IsDeleted && x.IsOrder, cancellationToken);
        
        if (userAddress is null)
        {
            return Result.Failure(new Error("404", "User's Address not Existed !"));
        }
        
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
            Address = userAddress.Address + "-" + userAddress.PhoneNumber,
            Note = string.Empty,
            Total = total,
            UserId = request.UserId, // Consider setting this to the actual user ID
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

        
        var urlSea = $"https://qr.sepay.vn/img?bank=MBBank&acc=0901928382&template=&amount={order.Total}&des=AntreeOrder{order.Id}";
        var result = new
        {
            OrderId = order.Id,
            BankNumber = "0901928382",
            BankGateway = "MB Bank",
            OrderTotal = order.Total,
            OrderDescription = order.Id,
            QrUrl = urlSea,
        };
        
        //string url = _vnPayService.CreatePaymentUrl(order);
        
        await _cacheService.RemoveByPrefixAsync($"{nameof(Query.GetProductsQuery)}", cancellationToken);
        
        return Result.Success(result);
    }
}