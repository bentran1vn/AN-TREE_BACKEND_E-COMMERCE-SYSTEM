using Antree_Ecommerce_BE.Application.Abstractions;
using Antree_Ecommerce_BE.Contract.Extensions;
using Antree_Ecommerce_BE.Presentation.Abstractions;
using Antree_Ecommerce_BE.Presentation.Constrants;
using Carter;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace Antree_Ecommerce_BE.Presentation.APIs.Feedbacks;

using CommandV1 = Antree_Ecommerce_BE.Contract.Services.Feedbacks.Command;
using QueryV1 = Antree_Ecommerce_BE.Contract.Services.Feedbacks.Query;
public class FeedbackApi : ApiEndpoint, ICarterModule
{
    private const string BaseUrl = "/api/v{version:apiVersion}/feedbacks";
    
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group1 = app.NewVersionedApi("Feedbacks")
            .MapGroup(BaseUrl).HasApiVersion(1);
        
        group1.MapGet(string.Empty, GetFeedbacksV1);
        group1.MapPost(string.Empty, CreateFeedbacksV1)
            .RequireAuthorization(RoleNames.Customer)
            .Accepts<CommandV1.CreateFeedbackCommand>("multipart/form-data")
            .DisableAntiforgery();
        // group1.MapDelete("{feedbackId}", () => { });
        // group1.MapPut(string.Empty, () => { });
    }

    public async static Task<IResult> GetFeedbacksV1(ISender sender, Guid productId,
        string? sortColumn = null,
        string? sortOrder = null,
        int pageIndex = 1,
        int pageSize = 10)
    {
        var result = await sender.Send(new QueryV1.GetFeedbacksQuery(
            productId, sortColumn, SortOrderExtension.ConvertStringToSortOrder(sortOrder),
            pageIndex, pageSize)
        );
        
        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }

    public async static Task<IResult> CreateFeedbacksV1(ISender sender,
        HttpContext context, IJwtTokenService jwtTokenService,
        [FromForm] CommandV1.CreateFeedbackCommand command)
    {
        var accessToken = await context.GetTokenAsync("access_token");
        var (claimPrincipal, _)  = jwtTokenService.GetPrincipalFromExpiredToken(accessToken!);
        var userId = claimPrincipal.Claims.FirstOrDefault(c => c.Type == "UserId")!.Value;
        command.UserId = new Guid(userId);
        var result = await sender.Send(command);

        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }
}