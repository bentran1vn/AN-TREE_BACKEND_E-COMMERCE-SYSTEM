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

        order.Status = 2;

        return Result.Success("Oker");
    }
}