namespace Antree_Ecommerce_BE.Contract.Services.Subscriptions;

public static class Response
{
    public record GetAllSubscription(Guid Id, string Name ,int Wait, decimal Price);
}