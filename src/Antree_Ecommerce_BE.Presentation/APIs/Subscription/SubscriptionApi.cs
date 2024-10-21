using Antree_Ecommerce_BE.Presentation.Abstractions;
using Carter;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace Antree_Ecommerce_BE.Presentation.APIs.Subscription;

public class SubscriptionApi : ApiEndpoint, ICarterModule
{
    private const string BaseUrl = "/api/v{version:apiVersion}/subscriptions";
    
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group1 = app.NewVersionedApi("Subscriptions")
            .MapGroup(BaseUrl).HasApiVersion(1);

        group1.MapGet(string.Empty, () =>
        {

        });
        
        group1.MapGet("{subscriptionId}", () =>
        {

        });
        
        group1.MapPost(string.Empty, () =>
        {

        });
        
        group1.MapPost("sepay-payment", () =>
        {

        });
        
    }
}