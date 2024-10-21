using Antree_Ecommerce_BE.Application.Abstractions;
using Antree_Ecommerce_BE.Contract.Services.Subscriptions;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;
using Antree_Ecommerce_BE.Presentation.Abstractions;
using Antree_Ecommerce_BE.Presentation.Constrants;
using Carter;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;

namespace Antree_Ecommerce_BE.Presentation.APIs.Subscription;

public class SubscriptionApi : ApiEndpoint, ICarterModule
{
    private const string BaseUrl = "/api/v{version:apiVersion}/subscriptions";
    
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group1 = app.NewVersionedApi("Subscriptions")
            .MapGroup(BaseUrl).HasApiVersion(1);

        group1.MapGet(string.Empty, GetSubscriptions)
            .RequireAuthorization();
        
        group1.MapPost(string.Empty, BuySubscriptions)
            .RequireAuthorization(RoleNames.Customer);
        
        group1.MapPost("sepay-payment", SePayCallBack);
        
        group1.MapPost("transaction", async (IRepositoryBase<Transaction, Guid> repositoryBase) =>
            {
                var result = await repositoryBase.FindAll().ToListAsync();
                return result;
            })
        .RequireAuthorization(RoleNames.Admin);
    }
    
    public static async Task<IResult> GetSubscriptions(ISender sender)
    {
        var result = await sender.Send(new Query.GetAllSubscriptionsQuery());
        
        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }
    
    public static async Task<IResult> BuySubscriptions(ISender sender, HttpContext context, IJwtTokenService jwtTokenService
        , [FromBody] Command.BuySubscriptionsCommand request)
    {
        var accessToken = await context.GetTokenAsync("access_token");
        var (claimPrincipal, _)  = jwtTokenService.GetPrincipalFromExpiredToken(accessToken!);
        var userId = claimPrincipal.Claims.FirstOrDefault(c => c.Type == "UserId")!.Value;
        request.UserId = new Guid(userId);
        var result = await sender.Send(request);
        
        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }
    
    public static async Task<IResult> SePayCallBack(ISender sender, [FromBody] Command.CreateSePayTranCommand command)
    {
        var result = await sender.Send(command);
        var response = new { success = true };
        return Results.Json(response);
    }
}