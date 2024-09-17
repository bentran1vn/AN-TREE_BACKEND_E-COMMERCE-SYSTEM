using Antree_Ecommerce_BE.Presentation.Abstractions;
using Carter;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace Antree_Ecommerce_BE.Presentation.APIs.Orders;

public class OrderApi : ApiEndpoint, ICarterModule
{
    private const string BaseUrl = "/api/v{version:apiVersion}/orders";
    
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group1 = app.NewVersionedApi("Orders")
            .MapGroup(BaseUrl).HasApiVersion(1);
        
        // group1.MapGet(string.Empty, () => { });
        // group1.MapGet("{orderId}", () => { });
        // group1.MapPost(string.Empty, () => { });
        // group1.MapDelete("{orderId}", () => { });
        // group1.MapPut("{orderId}", () => { });
    }
}