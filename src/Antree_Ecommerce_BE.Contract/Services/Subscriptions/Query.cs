using Antree_Ecommerce_BE.Contract.Abstractions.Messages;

namespace Antree_Ecommerce_BE.Contract.Services.Subscriptions;

public static class Query
{
    public record GetAllSubscriptionsQuery() : IQuery<List<Response.GetAllSubscription>>;
}