using Antree_Ecommerce_BE.Presentation.Abstractions;
using Carter;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace Antree_Ecommerce_BE.Presentation.APIs.Orders;

using CommandV1 = Antree_Ecommerce_BE.Contract.Services.Orders;

public class OrderApi : ApiEndpoint, ICarterModule
{
    private const string BaseUrl = "/api/v{version:apiVersion}/orders";
    
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group1 = app.NewVersionedApi("Orders")
            .MapGroup(BaseUrl).HasApiVersion(1);
        
        // group1.MapGet(string.Empty, () => { });
        // group1.MapGet("{orderId}", () => { });
        group1.MapPost(string.Empty, CreateOrdersV1);
        // group1.MapDelete("{orderId}", () => { });
        // group1.MapPut("{orderId}", () => { });
    }
    
    public static async Task<IResult> CreateOrdersV1(ISender sender, HttpContext context, [FromBody] CommandV1.Command.CreateOrderCommand request)
    {
        var result = await sender.Send(request);
        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }
}