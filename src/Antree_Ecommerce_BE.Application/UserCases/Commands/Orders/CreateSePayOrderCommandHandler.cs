using System.Text.RegularExpressions;
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
        var id = new Guid("9eddf230-6113-4803-93f4-cc1485d3ec1a");

        var order = await _orderRepository.FindByIdAsync(id, cancellationToken);

        order.Status = 5;

        var orderId = "";
        string note = request.content;
        Match match = Regex.Match(note, @"QR\s+([^\s]+)");  // Regular expression to match non-space characters after "QR"

        if (match.Success)
        {
            orderId = match.Groups[1].Value;
        }
        order.Note = orderId + "-" + request.gateway + "" + request.accountNumber + "-" + request.transferAmount;
        // QR   orderId12345- Ma GD ACSP/ qG580192-

        return Result.Success("Oker");
    }
}