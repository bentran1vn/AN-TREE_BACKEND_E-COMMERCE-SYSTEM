using System.Security.Claims;
using Antree_Ecommerce_BE.Application.Abstractions;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Identity;

namespace Antree_Ecommerce_BE.Application.UserCases.Queries.Identity;

public class GetTokenQueryHandler : IQueryHandler<Query.Token, Response.Authenticated>
{
    private readonly IJwtTokenService _jwtTokenService;
    private readonly ICacheService _cacheService;
    
    public GetTokenQueryHandler(IJwtTokenService jwtTokenService, ICacheService cacheService)
    {
        _jwtTokenService = jwtTokenService;
        _cacheService = cacheService;
    }
    
    public async Task<Result<Response.Authenticated>> Handle(Query.Token request, CancellationToken cancellationToken)
    {
        var (claimPrincipal, isExpired)  = _jwtTokenService.GetPrincipalFromExpiredToken(request.AccessToken);
        var email = claimPrincipal.Identity!.Name;
        var cacheData = await _cacheService.GetAsync<Response.Authenticated>(email, cancellationToken);
        
        if (cacheData == null || !cacheData.RefreshToken!.Equals(request.RefreshToken))
        {
            throw new Exception("Invalid refresh token");
        }
        
        if (!isExpired)
        {
            return Result.Success(cacheData!);
        }
        
        var accessToken = _jwtTokenService.GenerateAccessToken(claimPrincipal.Claims);
        var response = new Response.Authenticated()
        {
            AccessToken = accessToken,
            RefreshToken = cacheData.RefreshToken,
            RefreshTokenExpiryTime = DateTime.Now.AddMinutes(5)
        };
        await _cacheService.SetAsync(email, response, cancellationToken);

        return Result.Success(response);
    }
}