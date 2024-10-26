using Antree_Ecommerce_BE.Application.Exceptions;
using Antree_Ecommerce_BE.Application.SignalR;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Subscriptions;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;

namespace Antree_Ecommerce_BE.Application.UserCases.Commands.Subscriptions;

public class CreateSePayTranCommandHandler : ICommandHandler<Command.CreateSePayTranCommand>
{
    private readonly IRepositoryBase<Transaction, Guid> _tranRepository;
    private readonly PaymentService _paymentService;

    public CreateSePayTranCommandHandler(IRepositoryBase<Transaction, Guid> tranRepository, PaymentService paymentService)
    {
        _tranRepository = tranRepository;
        _paymentService = paymentService;
    }

    public async Task<Result> Handle(Command.CreateSePayTranCommand request, CancellationToken cancellationToken)
    {
        
        var tran = await _tranRepository.FindByIdAsync(request.transactionId, cancellationToken);

        if (tran == null || tran.IsDeleted)
        {
            return Result.Failure(new Error("400", "Tran is not exist !"));
        }
        
        var isPaymentSuccessful = Math.Round(tran.Total, 2).Equals(Math.Round(Convert.ToDecimal(request.transferAmount), 2));
        tran.Status = isPaymentSuccessful ? 1 : 2;
        tran.Note = request.transactionId + "-" + request.transferAmount + "-" + request.transactionDate;
        await _paymentService.ProcessPayment(tran.Id.ToString(), isPaymentSuccessful);
        
        return Result.Success("Oker");
    }
}