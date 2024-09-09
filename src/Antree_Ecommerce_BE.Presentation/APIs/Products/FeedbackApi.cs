using Antree_Ecommerce_BE.Contract.Extensions;
using Antree_Ecommerce_BE.Presentation.Abstractions;
using Carter;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Antree_Ecommerce_BE.Presentation.APIs.Products;

using CommandV1 = Antree_Ecommerce_BE.Contract.Services.Feedbacks;
public class FeedbackApi : ApiEndpoint, ICarterModule
{
    private const string BaseUrl = "/api/v{version:apiVersion}/feedbacks";
    
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group1 = app.NewVersionedApi("Feedbacks")
            .MapGroup(BaseUrl).HasApiVersion(1);
        
        group1.MapGet(string.Empty, GetFeedbacksV1);
        group1.MapGet("{productId}", () => { });
        group1.MapPost(string.Empty, () => { });
        group1.MapDelete("{feedbackId}", () => { });
        group1.MapPut("{orderId}", () => { });
    }

    public async static Task<IResult> GetFeedbacksV1(ISender sender, Guid? productId = null,
        string? sortColumn = null,
        string? sortOrder = null,
        int pageIndex = 1,
        int pageSize = 10)
    {
        var result = await sender.Send(new CommandV1.Query.GetFeedbacksQuery(
            productId, sortColumn, SortOrderExtension.ConvertStringToSortOrder(sortOrder),
            pageIndex, pageSize)
        );
        
        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }
}