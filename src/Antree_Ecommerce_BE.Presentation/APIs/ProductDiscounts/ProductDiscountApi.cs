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

namespace Antree_Ecommerce_BE.Presentation.APIs.ProductDiscounts;

using CommandV1 = Contract.Services.ProductDiscounts.Command;
using QueryV1 = Contract.Services.ProductDiscounts.Query;

public class ProductDiscountApi : ApiEndpoint, ICarterModule
{
    private const string BaseUrl = "/api/v{version:apiVersion}/productDiscounts";
    
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group1 = app.NewVersionedApi("ProductDiscounts")
            .MapGroup(BaseUrl).HasApiVersion(1);
        
        group1.MapGet("{productId}", GetProductDiscountsV1)
            .RequireAuthorization(RoleNames.Seller);
        group1.MapPost(string.Empty, CreateProductDiscountsV1)
            .RequireAuthorization(RoleNames.Seller);
        group1.MapPut(string.Empty, UpdateProductDiscountsV1)
            .RequireAuthorization(RoleNames.Seller);
        group1.MapDelete("{discountId}", () => { })
            .RequireAuthorization(RoleNames.Seller);
    }

    public static async Task<IResult> GetProductDiscountsV1(ISender sender,
        HttpContext context, IJwtTokenService jwtTokenService,
        Guid productId,
        bool isRelease = false,
        string? sortColumn = null,
        string? sortOrder = null,
        int pageIndex = 1,
        int pageSize = 10)
    {
        var accessToken = await context.GetTokenAsync("access_token");
        var (claimPrincipal, _)  = jwtTokenService.GetPrincipalFromExpiredToken(accessToken!);
        var vendorId = claimPrincipal.Claims.FirstOrDefault(c => c.Type == "VendorId")!.Value;

        if (string.IsNullOrWhiteSpace(vendorId))
        {
            var result1 = Result.Failure(new Error("404", "Please Create Vendor !"));
            
            if (result1.IsFailure)
                return HandlerFailure(result1);
        }
        
        var result =  await sender.Send(new QueryV1.GetProductDiscountsQuery(
            productId,
            new Guid(vendorId),
            isRelease,
            sortColumn,
            SortOrderExtension.ConvertStringToSortOrder(sortOrder),
            pageIndex,
            pageSize
        ));

        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }
    
    public static async Task<IResult> GetProductDiscountsesV1(ISender sender,
        HttpContext context, IJwtTokenService jwtTokenService,
        bool isRelease = false,
        string? sortColumn = null,
        string? sortOrder = null,
        int pageIndex = 1,
        int pageSize = 10)
    {
        var accessToken = await context.GetTokenAsync("access_token");
        var (claimPrincipal, _)  = jwtTokenService.GetPrincipalFromExpiredToken(accessToken!);
        var vendorId = claimPrincipal.Claims.FirstOrDefault(c => c.Type == "VendorId")!.Value;

        if (string.IsNullOrWhiteSpace(vendorId))
        {
            var result1 = Result.Failure(new Error("404", "Please Create Vendor !"));
            
            if (result1.IsFailure)
                return HandlerFailure(result1);
        }
        
        var result =  await sender.Send(new QueryV1.GetProductDiscountsesQuery(
            new Guid(vendorId),
            isRelease,
            sortColumn,
            SortOrderExtension.ConvertStringToSortOrder(sortOrder),
            pageIndex,
            pageSize
        ));

        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }
    
    public static async Task<IResult> CreateProductDiscountsV1(ISender sender,
        HttpContext context, IJwtTokenService jwtTokenService,
        [FromBody] CommandV1.CreateProductDiscountCommand request)
    {
        var accessToken = await context.GetTokenAsync("access_token");
        var (claimPrincipal, _)  = jwtTokenService.GetPrincipalFromExpiredToken(accessToken!);
        var vendorId = claimPrincipal.Claims.FirstOrDefault(c => c.Type == "VendorId")!.Value;

        if (string.IsNullOrWhiteSpace(vendorId))
        {
            var result1 = Result.Failure(new Error("404", "Please Create Vendor !"));
            
            if (result1.IsFailure)
                return HandlerFailure(result1);
        }
        
        request.VendorId = new Guid(vendorId);
        
        var result = await sender.Send(request);

        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }
    
    public static async Task<IResult> UpdateProductDiscountsV1(ISender sender,
        HttpContext context, IJwtTokenService jwtTokenService,
        [FromBody] CommandV1.UpdateProductDiscountCommand request)
    {
        var accessToken = await context.GetTokenAsync("access_token");
        var (claimPrincipal, _)  = jwtTokenService.GetPrincipalFromExpiredToken(accessToken!);
        var vendorId = claimPrincipal.Claims.FirstOrDefault(c => c.Type == "VendorId")!.Value;

        if (string.IsNullOrWhiteSpace(vendorId))
        {
            var result1 = Result.Failure(new Error("404", "Please Create Vendor !"));
            
            if (result1.IsFailure)
                return HandlerFailure(result1);
        }
        
        request.VendorId = new Guid(vendorId);
        
        var result = await sender.Send(request);

        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }
}