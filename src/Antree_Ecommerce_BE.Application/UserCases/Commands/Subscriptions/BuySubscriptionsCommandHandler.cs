using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Subscriptions;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Antree_Ecommerce_BE.Application.UserCases.Commands.Subscriptions;

public class BuySubscriptionsCommandHandler : ICommandHandler<Command.BuySubscriptionsCommand>
{
    private readonly IRepositoryBase<Subscription, Guid> _subscriptionRepository;
    private readonly IRepositoryBase<Transaction, Guid> _transactionRepository;
    private readonly IRepositoryBase<User, Guid> _userRepository;

    public BuySubscriptionsCommandHandler(IRepositoryBase<Subscription, Guid> subscriptionRepository, IRepositoryBase<Transaction, Guid> transactionRepository, IRepositoryBase<User, Guid> userRepository)
    {
        _subscriptionRepository = subscriptionRepository;
        _transactionRepository = transactionRepository;
        _userRepository = userRepository;
    }

    public async Task<Result> Handle(Command.BuySubscriptionsCommand request, CancellationToken cancellationToken)
    {
        var sub = await _subscriptionRepository.FindByIdAsync(request.SubscriptionId, cancellationToken);
        var user = await _userRepository.FindByIdAsync(request.UserId, cancellationToken);

        if (sub is null)
        {
            return Result.Failure(new Error("400", "Invalid Subscription !"));
        }
        
        if (user is null)
        {
            return Result.Failure(new Error("400", "Invalid User !"));
        }

        var tran = new Transaction()
        {
            Id = Guid.NewGuid(),
            UserId = user.Id,
            SubscriptionId = sub.Id,
            Note = request.UserId + "_" + sub.Name,
            Total = sub.Price ?? 0,
            Status = 0,
        };

        var transaction = await _transactionRepository.FindAll(
            x => x.UserId.Equals(user.Id) && !x.IsDeleted).ToListAsync(cancellationToken);

        var transactionEdit = transaction.Select(x =>
        {
            x.IsDeleted = true;
            return x;
        }).ToList();
        
        _transactionRepository.UpdateRange(transactionEdit);
        
        _transactionRepository.Add(tran);
        
        var urlSea = $"https://qr.sepay.vn/img?bank=MBBank&acc=0901928382&template=&amount={tran.Total}&des=AntreeSub{tran.Id}";
        
        var result = new
        {
            TranId = tran.Id,
            BankNumber = "0901928382",
            BankGateway = "MB Bank",
            TranTotal = tran.Total,
            TranDescription = tran.Id,
            QrUrl = urlSea,
        };

        return Result.Success(result);
    }
}