using Antree_Ecommerce_BE.Application.Abstractions;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Orders;
using Antree_Ecommerce_BE.Domain.Entities;

namespace Antree_Ecommerce_BE.Application.UserCases.Commands.Orders;

public class CreateOrderCommandHandler : ICommandHandler<Command.CreateOrderCommand>
{
    private readonly IVnPayService _vnPayService;

    public CreateOrderCommandHandler(IVnPayService vnPayService)
    {
        _vnPayService = vnPayService;
    }

    public async Task<Result> Handle(Command.CreateOrderCommand request, CancellationToken cancellationToken)
    {
        string url = _vnPayService.CreatePaymentUrl(new Order
        {
            Id = Guid.NewGuid(),
            Address = "BienHoa",
            Total = 1000000,
            Note = "noting",
            Status = 0,
        });
        return Result.Success(url);
    }
}