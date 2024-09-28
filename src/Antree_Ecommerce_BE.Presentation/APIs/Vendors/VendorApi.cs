using System.Security.Claims;
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

namespace Antree_Ecommerce_BE.Presentation.APIs.Vendors;

using CommandV1 = Antree_Ecommerce_BE.Contract.Services.Vendors.Command;
using QueryV1 = Antree_Ecommerce_BE.Contract.Services.Vendors.Query;

public class VendorApi : ApiEndpoint, ICarterModule
{
    private const string BaseUrl = "/api/v{version:apiVersion}/vendors";
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group1 = app.NewVersionedApi("Vendors")
            .MapGroup(BaseUrl).HasApiVersion(1);

        group1.MapGet("me", GetVendorV1)
            .RequireAuthorization(RoleNames.Seller);
        
        group1.MapGet("{vendorId}", GetVendorByIdV1)
            .RequireAuthorization(RoleNames.Admin);
        
        group1.MapGet("", GetVendorsV1)
            .RequireAuthorization(RoleNames.Admin);
        
        group1.MapPost(string.Empty, CreateVendorV1)
            .RequireAuthorization(RoleNames.Seller)
            .Accepts<CommandV1.CreateVendorCommand>("multipart/form-data")
            .DisableAntiforgery();
        
        group1.MapDelete(string.Empty, DeleteVendorV1)
            .RequireAuthorization(RoleNames.Seller);
        
        group1.MapPut(string.Empty, UpdateVendorV1)
            .RequireAuthorization(RoleNames.Seller)
            .Accepts<CommandV1.UpdateVendorCommand>("multipart/form-data")
            .DisableAntiforgery();

        group1.MapPost("confirm_update", ConfirmUpdateVendorByIdV1)
            .RequireAuthorization(RoleNames.Seller);
    }
    
    public async Task<IResult> CreateVendorV1(ISender sender, HttpContext context, IJwtTokenService jwtTokenService, [FromForm] CommandV1.CreateVendorCommand command)
    {
        var accessToken = await context.GetTokenAsync("access_token");
        var (claimPrincipal, _)  = jwtTokenService.GetPrincipalFromExpiredToken(accessToken!);
        var userId = claimPrincipal.Claims.FirstOrDefault(c => c.Type == "UserId")!.Value;
        
        var result = await sender.Send(new CommandV1.CreateVendorCommand(){
            Id = Guid.NewGuid(),
            UserId = new Guid(userId),
            VendorEmail = command.VendorEmail,
            VendorName = command.VendorName,
            Address = command.Address,
            City = command.City,
            Province = command.Province,
            PhoneNumber = command.PhoneNumber,
            AvatarImage = command.AvatarImage,
            CoverImage = command.CoverImage,
            BankName = command.BankName,
            BankOwnerName = command.BankOwnerName,
            BankAccountNumber = command.BankAccountNumber
        });

        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }
    public async Task<IResult> DeleteVendorV1(ISender sender, HttpContext context, IJwtTokenService jwtTokenService)
    {
        var accessToken = await context.GetTokenAsync("access_token");
        var (claimPrincipal, _)  = jwtTokenService.GetPrincipalFromExpiredToken(accessToken!);
        var userId = claimPrincipal.Claims.FirstOrDefault(c => c.Type == "UserId")!.Value;
        
        var result = await sender.Send(new CommandV1.DeleteVendorCommand(new Guid(userId)));

        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }
    public async Task<IResult> UpdateVendorV1(ISender sender, HttpContext context, IJwtTokenService jwtTokenService, [FromForm] CommandV1.UpdateVendorCommand command)
    {
        var accessToken = await context.GetTokenAsync("access_token");
        var (claimPrincipal, _)  = jwtTokenService.GetPrincipalFromExpiredToken(accessToken!);
        var vendorId = claimPrincipal.Claims.FirstOrDefault(c => c.Type == "VendorId")!.Value;
        
        var result = await sender.Send(new CommandV1.UpdateVendorCommand(){
            VendorId = new Guid(vendorId),
            VendorEmail = command.VendorEmail,
            VendorName = command.VendorName,
            Address = command.Address,
            City = command.City,
            Province = command.Province,
            PhoneNumber = command.PhoneNumber,
            AvatarImage = command.AvatarImage,
            CoverImage = command.CoverImage,
            BankName = command.BankName,
            BankOwnerName = command.BankOwnerName,
            BankAccountNumber = command.BankAccountNumber
        });

        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }
    public async Task<IResult> GetVendorV1(ISender sender, HttpContext context, IJwtTokenService jwtTokenService)
    {
        var accessToken = await context.GetTokenAsync("access_token");
        var (claimPrincipal, _)  = jwtTokenService.GetPrincipalFromExpiredToken(accessToken!);
        var vendorId = claimPrincipal.Claims.FirstOrDefault(c => c.Type == "VendorId")!.Value;

        Result result = await sender.Send(new QueryV1.GetVendorByIdQuery(new Guid(vendorId)));
        
        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }
    public async Task<IResult> GetVendorsV1(ISender sender,
        string? serchTerm = null,
        string? sortColumn = null,
        string? sortOrder = null,
        int pageIndex = 1,
        int pageSize = 10)
    {
        Result result =  await sender.Send(new QueryV1.GetVendorsQuery(
            serchTerm,
            sortColumn,
            SortOrderExtension.ConvertStringToSortOrder(sortOrder),
            pageIndex,
            pageSize
        ));

        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }

    public async Task<IResult> GetVendorByIdV1(ISender sender, Guid vendorId)
    {
        Result result = await sender.Send(new QueryV1.GetVendorByIdQuery(vendorId));
        
        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }
    
    public async Task<IResult> ConfirmUpdateVendorByIdV1(ISender sender, HttpContext context,
        IJwtTokenService jwtTokenService, [FromBody] CommandV1.ConfirmUpdateVendorCommand command)
    {
        var accessToken = await context.GetTokenAsync("access_token");
        var (claimPrincipal, _)  = jwtTokenService.GetPrincipalFromExpiredToken(accessToken!);
        var userId = claimPrincipal.Claims.FirstOrDefault(c => c.Type == "UserId")!.Value;
        Result result = await sender.Send(new CommandV1.ConfirmUpdateVendorCommand()
        {
            UserId = new Guid(userId),
            VendorEmail = command.VendorEmail,
            BankAccountNumber = command.BankAccountNumber,
            PhoneNumber = command.PhoneNumber,
            BankOwnerName = command.BankOwnerName,
            BankName = command.BankName,
            VerifyCode = command.VerifyCode
        });
        
        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }
}