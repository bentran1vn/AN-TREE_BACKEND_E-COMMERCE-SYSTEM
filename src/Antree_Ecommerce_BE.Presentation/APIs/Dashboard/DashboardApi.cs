using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Dashboards;
using Antree_Ecommerce_BE.Presentation.Abstractions;
using Antree_Ecommerce_BE.Presentation.Constrants;
using Carter;
using MediatR;
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

        group1.MapGet(string.Empty, GetDashboardV1)
            .WithSummary("Get All The Order And Subscription Revenue in Month And Week !")
            .WithDescription("Month must be in pattern MM-YYYY")
            .RequireAuthorization(RoleNames.Admin);
    }
    
    public static async Task<IResult> GetDashboardV1(ISender sender,
        string? month = null,
        string? year = null,
        bool isOrder = true)
    {
        Result result;
        if (isOrder)
        {
            result = await sender.Send(new Query.GetOrderDashboardQuery(month, year));
        }
        else
        {
            result = await sender.Send(new Query.GetSubDashboardQuery(month, year));
        }
        
        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }
}