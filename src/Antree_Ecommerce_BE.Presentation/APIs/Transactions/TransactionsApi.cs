using Antree_Ecommerce_BE.Application.Abstractions;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Transactions;
using Antree_Ecommerce_BE.Presentation.Abstractions;
using Carter;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Antree_Ecommerce_BE.Presentation.APIs.Transactions;

public class TransactionsApi : ApiEndpoint, ICarterModule
{
    private const string BaseUrl = "/api/v{version:apiVersion}/transactions";
    
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group1 = app.NewVersionedApi("Transactions")
            .MapGroup(BaseUrl).HasApiVersion(1);

        group1.MapGet(string.Empty, GetAllTransactions)
            .WithSummary("Get All Transaction With The following Role !")
            .RequireAuthorization();
    }
    
    public static async Task<IResult> GetAllTransactions(ISender sender,
        HttpContext context, IJwtTokenService jwtTokenService,
        string? serchTerm = null,
        int pageIndex = 1,
        int pageSize = 10)
    {
        var accessToken = await context.GetTokenAsync("access_token");
        var (claimPrincipal, _)  = jwtTokenService.GetPrincipalFromExpiredToken(accessToken!);
        var userId = claimPrincipal.Claims.FirstOrDefault(c => c.Type == "UserId")!.Value;
        var role = claimPrincipal.Claims.FirstOrDefault(c => c.Type == "Role")!.Value;

        Result result;
        
        if (role.Equals("0"))
        {
            result = await sender.Send(new Query.GetAllTransactionsQuery(
                new Guid(userId), serchTerm, pageIndex, pageSize));
        } else if (role.Equals("2"))
        {
            result = await sender.Send(new Query.GetAllTransactionsQuery(
                null, serchTerm, pageIndex, pageSize));
        }
        else
        {
            result = Result.Failure(new Error("401", "Unauthorized !"));
        }
        
        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }
}