using Antree_Ecommerce_BE.Contract.Extensions;
using Antree_Ecommerce_BE.Presentation.Abstractions;
using Carter;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace Antree_Ecommerce_BE.Presentation.APIs.Products;


using CommandV1 = Antree_Ecommerce_BE.Contract.Services.Products;
public class ProductApi : ApiEndpoint, ICarterModule
{
    private const string BaseUrl = "/api/v{version:apiVersion}/products";
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group1 = app.NewVersionedApi("Products")
            .MapGroup(BaseUrl).HasApiVersion(1);
        //.RequireAuthorization();
        group1.MapGet(string.Empty, GetProductsV1);//.RequireAuthorization();
        group1.MapGet("{productId}", GetProductV1);
        group1.MapPost(string.Empty, CreateProductsV1).Accepts<CommandV1.Command.CreateProductCommand>("multipart/form-data").DisableAntiforgery();;
        group1.MapDelete("{productId}", DeleteProductsV1);
        group1.MapPut("{productId}", UpdateProductsV1);
    }

    #region ====== version 1 ======

    public static async Task<IResult> GetProductsV1(ISender sender, string? serchTerm = null,
        Guid? categoryId = null,
        string? sortColumn = null,
        string? sortOrder = null,
        int pageIndex = 1,
        int pageSize = 10)
    {
        var result = await sender.Send(new CommandV1.Query.GetProductsQuery(serchTerm, categoryId, sortColumn,
            SortOrderExtension.ConvertStringToSortOrder(sortOrder),
            pageIndex,
            pageSize));

        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }
    
    public static async Task<IResult> GetProductV1(ISender sender, Guid productId)
    {
        var result = await sender.Send(new CommandV1.Query.GetProductByIdQuery(productId));

        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result); 
    }
    
    public static async Task<IResult> CreateProductsV1(ISender sender, [FromForm] CommandV1.Command.CreateProductCommand createProduct)
    {
        var result = await sender.Send(createProduct);

        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }
    
    public static async Task<IResult> UpdateProductsV1(ISender sender, Guid productId, [FromBody] CommandV1.Command.UpdateProductCommand updateProduct)
    {
        var updateProductCommand = new CommandV1.Command.UpdateProductCommand(productId, updateProduct.ProductCategoryId, updateProduct.Name, updateProduct.Price, updateProduct.Description, updateProduct.Sku, updateProduct.Sold);
        var result = await sender.Send(updateProductCommand);
        return Results.Ok(result);
    }

    public static async Task<IResult> DeleteProductsV1(ISender sender, Guid productId)
    {
        var result = await sender.Send(new CommandV1.Command.DeleteProductCommand(productId));
        return Results.Ok(result);
    }
    
    #endregion ====== version 1 ======

}