using System.Text.RegularExpressions;
using Antree_Ecommerce_BE.Application.Exceptions;
using Antree_Ecommerce_BE.Application.SignalR;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Orders;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;

namespace Antree_Ecommerce_BE.Application.UserCases.Commands.Orders;

public class CreateSePayOrderCommandHandler : ICommandHandler<Command.CreateSePayOrderCommand>
{
    private readonly IRepositoryBase<Order, Guid> _orderRepository;
    private readonly PaymentService _paymentService;

    public CreateSePayOrderCommandHandler(IRepositoryBase<Order, Guid> orderRepository, PaymentService paymentService)
    {
        _orderRepository = orderRepository;
        _paymentService = paymentService;
    }

    public async Task<Result> Handle(Command.CreateSePayOrderCommand request, CancellationToken cancellationToken)
    {
        var orderId = OrderExtensions.TakeOrderIdFromContent(request.content);
        var order = await _orderRepository.FindByIdAsync(orderId, cancellationToken);

        if (order == null || order.IsDeleted)
        {
            return Result.Failure(new Error("400", "Order is not exist !"));
        }
        
        var isPaymentSuccessful = Math.Round(order.Total, 2).Equals(Math.Round(Convert.ToDecimal(request.transferAmount), 2));
        order.Status = isPaymentSuccessful ? 1 : 2;
        order.Note = orderId + "-" + request.transferAmount + "-" + request.transactionDate;
        await _paymentService.ProcessPayment(order.Id.ToString(), isPaymentSuccessful);
        
        return Result.Success("Oker");
    }
}