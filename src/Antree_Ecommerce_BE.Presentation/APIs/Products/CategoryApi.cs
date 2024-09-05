using Antree_Ecommerce_BE.Presentation.Abstractions;
using Carter;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace Antree_Ecommerce_BE.Presentation.APIs.Products;

using CommandV1 = Antree_Ecommerce_BE.Contract.Services.Categories;

public class CategoryApi : ApiEndpoint, ICarterModule
{
    private const string BaseUrl = "/api/v{version:apiVersion}/categorys";
    
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group1 = app.NewVersionedApi("Categorys")
            .MapGroup(BaseUrl).HasApiVersion(1);
        
        group1.MapGet(string.Empty, GetCategoriesV1);
        group1.MapGet("{categoryId}", () => { });
        group1.MapPost(string.Empty, CreateCategoryV1);
        group1.MapDelete("{categoryId}", () => { });
        group1.MapPut("{categoryId}", () => { });
    }

    #region ====== version 1 ======

    public static async Task<IResult> GetCategoriesV1(ISender sender)
    {
        var result = await sender.Send(new CommandV1.Query.GetCategoriesQuery());
        
        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }
    
    public static async Task<IResult> CreateCategoryV1(ISender sender, [FromBody]CommandV1.Command.CreateCategoryCommand request)
    {
        var result = await sender.Send(request);
        
        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }

    #endregion
}