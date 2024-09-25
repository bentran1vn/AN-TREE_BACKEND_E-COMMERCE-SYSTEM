using System.Globalization;
using Antree_Ecommerce_BE.Application.Abstractions;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Orders;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;

namespace Antree_Ecommerce_BE.Application.UserCases.Commands.Orders;

public class VerifyOrderCommandHandler : ICommandHandler<Command.VerifyOrderCommand>
{
    private readonly IRepositoryBase<Order, Guid> _orderRepository;
    private readonly IVnPayService _vnPayService;

    public VerifyOrderCommandHandler(IRepositoryBase<Order, Guid> orderRepository, IVnPayService vnPayService)
    {
        _orderRepository = orderRepository;
        _vnPayService = vnPayService;
    }

    public async Task<Result> Handle(Command.VerifyOrderCommand request, CancellationToken cancellationToken)
    {
        var (valid, message) = await _vnPayService.ValidateCallback(request.vnpayData);
        var order = await _orderRepository.FindByIdAsync(new Guid(request.vnpayData["vnp_TxnRef"]), cancellationToken);
        if (!valid)
        {
            order.Status= 1;
        }
        else
        {
            order.Status= 2;
        }
        return Result.Success(message);
    }
}