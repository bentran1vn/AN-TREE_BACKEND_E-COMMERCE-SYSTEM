using System.Text.RegularExpressions;
using Antree_Ecommerce_BE.Application.Exceptions;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Orders;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;

namespace Antree_Ecommerce_BE.Application.UserCases.Commands.Orders;

public class CreateSePayOrderCommandHandler : ICommandHandler<Command.CreateSePayOrderCommand>
{
    private readonly IRepositoryBase<Order, Guid> _orderRepository;

    public CreateSePayOrderCommandHandler(IRepositoryBase<Order, Guid> orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public async Task<Result> Handle(Command.CreateSePayOrderCommand request, CancellationToken cancellationToken)
    {
        var orderId = OrderExtensions.TakeOrderIdFromContent(request.content);
        var order = await _orderRepository.FindByIdAsync(orderId, cancellationToken);

        if (order == null || order.IsDeleted)
        {
            return Result.Failure(new Error("400", "Order is not exist !"));
        }

        if (order.Total.Equals(double.Parse(request.transferAmount!.ToString())))
        {
            order.Status = 1;
            order.Note = orderId + "-" + request.transferAmount + "-" + request.transactionDate;
        }
        else
        {
            order.Status = 2;
            order.Note = orderId + "-" + request.transferAmount + "-" + request.transactionDate;
            return Result.Failure(new Error("500", "Your charge is wrong !"));
        }
        return Result.Success("Oker");
    }
}