using Antree_Ecommerce_BE.Presentation.Abstractions;
using Carter;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace Antree_Ecommerce_BE.Presentation.APIs.Discounts;

using CommandV1 = Contract.Services.ProductDiscounts;

public class DiscountApi : ApiEndpoint, ICarterModule
{
    private const string BaseUrl = "/api/v{version:apiVersion}/productDiscounts";
    
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group1 = app.NewVersionedApi("ProductDiscounts")
            .MapGroup(BaseUrl).HasApiVersion(1);
        
        // group1.MapGet(string.Empty, () => { });
        group1.MapGet("{productId}", () => { });
        group1.MapPost(string.Empty, CreateProductDiscountsV1);
        // group1.MapDelete("{discountId}", () => { });
        // group1.MapPut("{discountId}", () => { });
    }
    
    public static async Task<IResult> CreateProductDiscountsV1(ISender sender, [FromBody] CommandV1.Command.CreateProductDiscountCommand request)
    {
        var result = await sender.Send(request);

        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }
}