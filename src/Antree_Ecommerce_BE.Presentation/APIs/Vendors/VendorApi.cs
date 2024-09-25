using Antree_Ecommerce_BE.Presentation.Abstractions;
using Carter;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace Antree_Ecommerce_BE.Presentation.APIs.Vendors;

public class VendorApi : ApiEndpoint, ICarterModule
{
    private const string BaseUrl = "/api/v{version:apiVersion}/vendors";
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group1 = app.NewVersionedApi("Vendors")
            .MapGroup(BaseUrl).HasApiVersion(1);
        
        group1.MapGet(string.Empty, () => {});
        group1.MapPost(string.Empty, () => { });
        group1.MapDelete(string.Empty, () => {});
    }
}