using Antree_Ecommerce_BE.Application.Abstractions;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
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

namespace Antree_Ecommerce_BE.Presentation.APIs.Products;


using CommandV1 = Antree_Ecommerce_BE.Contract.Services.Products.Command;
using QueryV1 = Antree_Ecommerce_BE.Contract.Services.Products.Query;
public class ProductApi : ApiEndpoint, ICarterModule
{
    private const string BaseUrl = "/api/v{version:apiVersion}/products";
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group1 = app.NewVersionedApi("Products")
            .MapGroup(BaseUrl).HasApiVersion(1);
        
        group1.MapGet(string.Empty, GetProductsV1);

        group1.MapGet("{productId}", GetProductV1);
        
        group1.MapPost(string.Empty, CreateProductsV1)
            .RequireAuthorization(RoleNames.Seller)
            .Accepts<CommandV1.CreateProductCommand>("multipart/form-data")
            .DisableAntiforgery();

        group1.MapPut("{productId}", UpdateProductsV1)
            .RequireAuthorization(RoleNames.Seller)
            .Accepts<CommandV1.UpdateProductCommand>("multipart/form-data")
            .DisableAntiforgery();
            
        
        group1.MapDelete("{productId}", DeleteProductsV1)
            .RequireAuthorization(RoleNames.Seller);
    }

    #region ====== version 1 ======

    public static async Task<IResult> GetProductsV1(ISender sender,
        string? serchTerm = null,
        string? categoryName = null,
        string? vendorName = null,
        string? sortColumn = null,
        string? sortOrder = null,
        bool isSale = false,
        int pageIndex = 1,
        int pageSize = 10)
    {
        var result = await sender.Send(new QueryV1.GetProductsQuery(
            serchTerm,
            categoryName,
            sortColumn,
            isSale,
            SortOrderExtension.ConvertStringToSortOrder(sortOrder),
            vendorName,
            pageIndex,
            pageSize));

        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }
    
    public static async Task<IResult> GetProductV1(ISender sender, Guid productId)
    {
        var result = await sender.Send(new QueryV1.GetProductByIdQuery(productId));

        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result); 
    }
    
    public static async Task<IResult> CreateProductsV1(ISender sender,
        [FromForm] CommandV1.CreateProductCommand createProduct)
    {
        var result = await sender.Send(createProduct);

        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }
    
    public static async Task<IResult> UpdateProductsV1(ISender sender, HttpContext context, IJwtTokenService jwtTokenService,
        Guid productId, [FromForm] CommandV1.UpdateProductCommand command)
    {
        var accessToken = await context.GetTokenAsync("access_token");
        var (claimPrincipal, _)  = jwtTokenService.GetPrincipalFromExpiredToken(accessToken!);
        var vendorId = claimPrincipal.Claims.FirstOrDefault(c => c.Type == "VendorId")!.Value;
        if (string.IsNullOrWhiteSpace(vendorId)){
            var result1 = Result.Failure(new Error("404", "Please Create Vendor !"));
            
            if (result1.IsFailure)
                return HandlerFailure(result1);
        }
        
        if (command.Id is null || !productId.Equals(new Guid(command.Id!)))
        {
            var result1 = Result.Failure(new Error("500", "Invalid Product Id"));
            return HandlerFailure(result1);
        }

        command.VendorId = new Guid(vendorId);
        
        var result = await sender.Send(command);
        
        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }

    public static async Task<IResult> DeleteProductsV1(ISender sender, HttpContext context, IJwtTokenService jwtTokenService, Guid productId)
    {
        var accessToken = await context.GetTokenAsync("access_token");
        var (claimPrincipal, _)  = jwtTokenService.GetPrincipalFromExpiredToken(accessToken!);
        var vendorId = claimPrincipal.Claims.FirstOrDefault(c => c.Type == "VendorId")!.Value;
        
        var result = await sender.Send(new CommandV1.DeleteProductCommand(productId, new Guid(vendorId)));
        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }
    
    #endregion ====== version 1 ======

}