using Antree_Ecommerce_BE.Application.Abstractions;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Dashboards;
using Antree_Ecommerce_BE.Presentation.Abstractions;
using Antree_Ecommerce_BE.Presentation.Constrants;
using Carter;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Antree_Ecommerce_BE.Presentation.APIs.Dashboard;

public class DashboardApi : ApiEndpoint, ICarterModule
{
    private const string BaseUrl = "/api/v{version:apiVersion}/dashboards";

    
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group1 = app.NewVersionedApi("Dashboards")
            .MapGroup(BaseUrl).HasApiVersion(1);

        group1.MapGet("Revenue", GetDashboardV1)
            .WithSummary("Get All The Order And Subscription Revenue in Month And Week !")
            .WithDescription("Month must be in pattern MM-YYYY")
            .RequireAuthorization(RoleNames.AdminAndSeller);
        
        group1.MapGet("Amount", GetAmountV1)
            .RequireAuthorization(RoleNames.Admin);
    }
    
    public static async Task<IResult> GetDashboardV1(ISender sender,
        HttpContext context,
        IJwtTokenService jwtTokenService,
        string? month = null,
        string? year = null,
        bool isOrder = true)
    {
        var accessToken = await context.GetTokenAsync("access_token");
        var (claimPrincipal, _)  = jwtTokenService.GetPrincipalFromExpiredToken(accessToken!);
        var userId = claimPrincipal.Claims.FirstOrDefault(c => c.Type == "UserId")!.Value;
        var vendorId = claimPrincipal.Claims.FirstOrDefault(c => c.Type == "VendorId")!.Value;
        var role = claimPrincipal.Claims.FirstOrDefault(c => c.Type == "Role")!.Value;
        
        Result result;
        if (role.Equals("1") || isOrder)
        {
            result = await sender.Send(new Query.GetOrderDashboardQuery(vendorId, month, year));
        }
        else
        {
            result = await sender.Send(new Query.GetSubDashboardQuery(month, year));
        }
        
        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }
    
    public static async Task<IResult> GetAmountV1(ISender sender)
    {
        Result result = await sender.Send(new Query.GetAdminAmountDashboardQuery());
        
        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }
}