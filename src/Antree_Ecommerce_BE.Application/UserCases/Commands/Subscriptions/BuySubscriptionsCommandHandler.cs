using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Subscriptions;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;

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

        var tran = new Transaction()
        {
            Id = Guid.NewGuid(),
            UserId = request.UserId,
            Note = request.UserId + "_" + sub.Name,
            Total = sub.Price ?? 0,
            Status = 0,
        };
        
        
        _transactionRepository.Add(tran);
        user.SubscriptionId = sub.Id;
        
        var urlSea = $"https://qr.sepay.vn/img?bank=MBBank&acc=0901928382&template=&amount={tran.Total}&des={tran.Id}";
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