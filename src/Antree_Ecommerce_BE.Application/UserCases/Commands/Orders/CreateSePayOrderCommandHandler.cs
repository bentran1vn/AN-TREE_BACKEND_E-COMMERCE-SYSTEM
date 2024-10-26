using System.Text.RegularExpressions;
using Antree_Ecommerce_BE.Application.Exceptions;
using Antree_Ecommerce_BE.Application.SignalR;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Orders;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;
using Microsoft.AspNetCore.SignalR;

namespace Antree_Ecommerce_BE.Application.UserCases.Commands.Orders;

public class CreateSePayOrderCommandHandler : ICommandHandler<Command.CreateSePayOrderCommand>
{
    private readonly IRepositoryBase<Order, Guid> _orderRepository;
    private readonly PaymentService _paymentService;
    private readonly IHubContext<PaymentHub> _hubContext;

    public CreateSePayOrderCommandHandler(IRepositoryBase<Order, Guid> orderRepository, PaymentService paymentService, IHubContext<PaymentHub> hubContext)
    {
        _orderRepository = orderRepository;
        _paymentService = paymentService;
        _hubContext = hubContext;
    }

    public async Task<Result> Handle(Command.CreateSePayOrderCommand request, CancellationToken cancellationToken)
    {
        var order = await _orderRepository.FindByIdAsync(request.orderId, cancellationToken);

        if (order == null || order.IsDeleted)
        {
            return Result.Failure(new Error("400", "Order is not exist !"));
        }
        
        var isPaymentSuccessful = Math.Round(order.Total, 2).Equals(Math.Round(Convert.ToDecimal(request.transferAmount), 2));
        order.Status = isPaymentSuccessful ? 1 : 2;
        order.Note = request.orderId + "-" + request.transferAmount + "-" + request.transactionDate;
        await _paymentService.ProcessPayment(order.Id.ToString(), isPaymentSuccessful);
        await _hubContext.Clients.All.SendAsync("ReceiveEvent", request.transferAmount, cancellationToken);
        
        return Result.Success("Oker");
    }
}