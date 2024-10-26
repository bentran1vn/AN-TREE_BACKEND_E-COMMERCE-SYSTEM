using Antree_Ecommerce_BE.Application.Abstractions;
using Antree_Ecommerce_BE.Contract.Services.UserAddress;
using Antree_Ecommerce_BE.Presentation.Abstractions;
using Antree_Ecommerce_BE.Presentation.Constrants;
using Carter;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace Antree_Ecommerce_BE.Presentation.APIs.UserAddress;

public class UserAddressApi : ApiEndpoint, ICarterModule
{
    private const string BaseUrl = "/api/v{version:apiVersion}/userAddresses";
    
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group1 = app.NewVersionedApi("UserAddress")
            .MapGroup(BaseUrl).HasApiVersion(1);

        group1.MapGet(string.Empty, GetAllUserAddress)
            .WithSummary("Get All UserAddress Of User !")
            .RequireAuthorization(RoleNames.Customer);
        
        group1.MapPost(string.Empty, CreateNewUserAddress)
            .WithSummary("Create New UserAddress Of User !")
            .RequireAuthorization(RoleNames.Customer);
        
        group1.MapPut(string.Empty, UpdateUserAddress)
            .WithSummary("Set The UserAddress Of User Is Order Delivery Address!")
            .RequireAuthorization(RoleNames.Customer);
    }
    
    public static async Task<IResult> GetAllUserAddress(ISender sender,
        HttpContext context, IJwtTokenService jwtTokenService)
    {
        var accessToken = await context.GetTokenAsync("access_token");
        var (claimPrincipal, _)  = jwtTokenService.GetPrincipalFromExpiredToken(accessToken!);
        var userId = claimPrincipal.Claims.FirstOrDefault(c => c.Type == "UserId")!.Value;

        var result = await sender.Send(new Query.GetAllUserAddressQuery(new Guid(userId)));
        
        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }
    
    public static async Task<IResult> CreateNewUserAddress(ISender sender,
        HttpContext context, IJwtTokenService jwtTokenService, [FromBody] Command.CreateUserAddressCommand command)
    {
        var accessToken = await context.GetTokenAsync("access_token");
        var (claimPrincipal, _)  = jwtTokenService.GetPrincipalFromExpiredToken(accessToken!);
        var userId = claimPrincipal.Claims.FirstOrDefault(c => c.Type == "UserId")!.Value;
        command.UserId = new Guid(userId);

        var result = await sender.Send(command);
        
        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }
    
    public static async Task<IResult> UpdateUserAddress(ISender sender,
        HttpContext context, IJwtTokenService jwtTokenService, [FromBody] Command.UpdateUserAddressCommand command)
    {
        var accessToken = await context.GetTokenAsync("access_token");
        var (claimPrincipal, _)  = jwtTokenService.GetPrincipalFromExpiredToken(accessToken!);
        var userId = claimPrincipal.Claims.FirstOrDefault(c => c.Type == "UserId")!.Value;
        command.UserId = new Guid(userId);

        var result = await sender.Send(command);
        
        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }
}