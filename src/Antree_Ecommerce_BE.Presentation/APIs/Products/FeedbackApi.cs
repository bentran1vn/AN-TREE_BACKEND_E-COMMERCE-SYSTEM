using Antree_Ecommerce_BE.Presentation.Abstractions;
using Carter;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace Antree_Ecommerce_BE.Presentation.APIs.Products;

public class FeedbackApi : ApiEndpoint, ICarterModule
{
    private const string BaseUrl = "/api/v{version:apiVersion}/feedbacks";
    
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group1 = app.NewVersionedApi("Feedbacks")
            .MapGroup(BaseUrl).HasApiVersion(1);
        
        group1.MapGet(string.Empty, () => { });
        group1.MapGet("{feedbackId}", () => { });
        group1.MapPost(string.Empty, () => { });
        group1.MapDelete("{feedbackId}", () => { });
        group1.MapPut("{orderId}", () => { });
    }
}