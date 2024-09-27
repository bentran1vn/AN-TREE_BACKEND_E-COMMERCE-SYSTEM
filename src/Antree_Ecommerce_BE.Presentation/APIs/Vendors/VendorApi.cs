using Antree_Ecommerce_BE.Application.Abstractions;
using Antree_Ecommerce_BE.Presentation.Abstractions;
using Carter;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace Antree_Ecommerce_BE.Presentation.APIs.Vendors;

using CommandV1 = Antree_Ecommerce_BE.Contract.Services.Vendors;

public class VendorApi : ApiEndpoint, ICarterModule
{
    private const string BaseUrl = "/api/v{version:apiVersion}/vendors";
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group1 = app.NewVersionedApi("Vendors")
            .MapGroup(BaseUrl).HasApiVersion(1);
        
        group1.MapGet(string.Empty, () => {});
        group1.MapPost(string.Empty, CreateVendorV1)
            .RequireAuthorization()
            .Accepts<CommandV1.Command.CreateVendorCommand>("multipart/form-data")
            .DisableAntiforgery();
        group1.MapDelete(string.Empty, DeleteVendorV1)
            .RequireAuthorization("1");
    }
    
    public async Task<IResult> CreateVendorV1(ISender sender, HttpContext context, IJwtTokenService jwtTokenService, [FromForm] CommandV1.Command.CreateVendorCommand command)
    {
        var accessToken = await context.GetTokenAsync("access_token");
        var (claimPrincipal, _)  = jwtTokenService.GetPrincipalFromExpiredToken(accessToken!);
        var userId = claimPrincipal.Claims.FirstOrDefault(c => c.Type == "UserId")!.Value;
        
        // var result = await sender.Send(new CommandV1.Command.CreateVendorCommand(
        //     new Guid(), new Guid(userId), command.VendorEmail,command.VendorName, command.Address,
        //     command.City, command.Province, command.PhoneNumber,command.AvatarImage, command.CoverImage,
        //     command.BankName, command.BankOwnerName, command.BankAccountNumber
        // ));
        
        var result = await sender.Send(new CommandV1.Command.CreateVendorCommand(){
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
        
        var result = await sender.Send(new CommandV1.Command.DeleteVendorCommand(new Guid(userId)));

        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }
}