using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Subscriptions;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Antree_Ecommerce_BE.Application.UserCases.Queries.Subscriptions;

public class GetAllSubscriptionsQueryHandler : IQueryHandler<Query.GetAllSubscriptionsQuery, List<Response.GetAllSubscription>>
{
    private readonly IRepositoryBase<Subscription, Guid> _subscriptionRepository;

    public GetAllSubscriptionsQueryHandler(IRepositoryBase<Subscription, Guid> subscriptionRepository)
    {
        this._subscriptionRepository = subscriptionRepository;
    }

    public async Task<Result<List<Response.GetAllSubscription>>> Handle(Query.GetAllSubscriptionsQuery request, CancellationToken cancellationToken)
    {
        var result = await _subscriptionRepository.FindAll(null).ToListAsync(cancellationToken);

        var map = result.Select(x => new Response.GetAllSubscription(x.Id, x.Name, x.Wait, x.Price ?? 0)).ToList();

        return Result.Success(map);
    }
}