using Antree_Ecommerce_BE.Presentation.Abstractions;
using Carter;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace Antree_Ecommerce_BE.Presentation.APIs.Products;

public class DiscountApi : ApiEndpoint, ICarterModule
{
    private const string BaseUrl = "/api/v{version:apiVersion}/discounts";
    
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group1 = app.NewVersionedApi("Discounts")
            .MapGroup(BaseUrl).HasApiVersion(1);
        
        group1.MapGet(string.Empty, () => { });
        group1.MapGet("{discountId}", () => { });
        group1.MapPost(string.Empty, () => { });
        group1.MapDelete("{discountId}", () => { });
        group1.MapPut("{discountId}", () => { });
    }
}