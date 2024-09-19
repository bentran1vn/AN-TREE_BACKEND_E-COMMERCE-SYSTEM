using Antree_Ecommerce_BE.Presentation.Abstractions;
using Carter;
using MediatR;
//using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace Antree_Ecommerce_BE.Presentation.APIs.Identity;

using CommandV1 = Contract.Services.Identity;

public class AuthApi : ApiEndpoint, ICarterModule
{
    private const string BaseUrl = "/api/v{version:apiVersion}/auth";
    
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group1 = app.NewVersionedApi("Authentication")
            .MapGroup(BaseUrl).HasApiVersion(1);
        
        // group1.MapGet(string.Empty, GetCategoriesV1);
        // group1.MapGet("{categoryId}", () => { });
        group1.MapPost("login", LoginV1);
        group1.MapPost("refresh_token", RefreshTokenV1);
        group1.MapPost("", RegisterV1);
    }

    public static async Task<IResult> LoginV1(ISender sender, [FromBody] CommandV1.Query.Login login)
    {
        var result = await sender.Send(login);
        
        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }
    public static async Task<IResult> RefreshTokenV1(HttpContext context, ISender sender, [FromBody] CommandV1.Query.Token query)
    {
        //var accessToken = await context.GetTokenAsync("access_token");
        var result = await sender.Send(query);
        
        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }

    public static async Task<IResult> RegisterV1(ISender sender, [FromBody] CommandV1.Command.RegisterCommand command)
    {
        var result = await sender.Send(command);
        
        if (result.IsFailure)
            return HandlerFailure(result);

        return Results.Ok(result);
    }
}