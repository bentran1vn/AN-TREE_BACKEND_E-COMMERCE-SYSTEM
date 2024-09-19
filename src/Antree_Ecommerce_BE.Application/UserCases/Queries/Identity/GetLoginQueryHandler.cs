using System.Security.Claims;
using Antree_Ecommerce_BE.Application.Abstractions;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Identity;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;
using Microsoft.Extensions.Caching.Distributed;

namespace Antree_Ecommerce_BE.Application.UserCases.Queries.Identity;

public class GetLoginQueryHandler : IQueryHandler<Query.Login, Response.Authenticated>
{
    private readonly IJwtTokenService _jwtTokenService;
    private readonly ICacheService _cacheService;
    private readonly IRepositoryBase<User, Guid> _userRepository;
    private readonly IPasswordHasherService _passwordHasherService;

    public GetLoginQueryHandler(IJwtTokenService jwtTokenService, ICacheService cacheService, IRepositoryBase<User, Guid> userRepository, IPasswordHasherService passwordHasherService)
    {
        _jwtTokenService = jwtTokenService;
        _cacheService = cacheService;
        _userRepository = userRepository;
        _passwordHasherService = passwordHasherService;
    }

    public async Task<Result<Response.Authenticated>> Handle(Query.Login request, CancellationToken cancellationToken)
    {
        // Check User
        var user =
            await _userRepository.FindSingleAsync(x =>
                x.Email.Equals(request.EmailOrUserName) || x.Username.Equals(request.EmailOrUserName), cancellationToken);
        
        if (user is null)
        {
            throw new Exception("User Not Existed !");
        }

        if (!_passwordHasherService.VerifyPassword(request.Password, user.Password))
        {
            throw new UnauthorizedAccessException("UnAuthorize !");
        }
        
        // Generate JWT Token
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Email, request.EmailOrUserName),
            new Claim(ClaimTypes.Role, user.Role.ToString()),
            new Claim("Role", user.Role.ToString()),
            new Claim(ClaimTypes.Name, request.EmailOrUserName),
            // new Claim(ClaimTypes.Expired, DateTime.Now.AddMinutes(5).ToString())
        };

        var accessToken = _jwtTokenService.GenerateAccessToken(claims);
        var refreshToken = _jwtTokenService.GenerateRefreshToken();

        var response = new Response.Authenticated()
        {
            AccessToken = accessToken,
            RefreshToken = refreshToken,
            RefreshTokenExpiryTime = DateTime.Now.AddMinutes(15)
        };
        
        var slidingExpiration = request.SlidingExpirationInMinutes == 0 ? 10 : request.SlidingExpirationInMinutes;
        var absoluteExpiration = request.AbsoluteExpirationInMinutes == 0 ? 15 : request.AbsoluteExpirationInMinutes;
        var options = new DistributedCacheEntryOptions()
            .SetSlidingExpiration(TimeSpan.FromMinutes(slidingExpiration))
            .SetAbsoluteExpiration(TimeSpan.FromMinutes(absoluteExpiration));
        
        await _cacheService.SetAsync($"{nameof(Query.Login)}-UserAccount:{request.EmailOrUserName}", response, options, cancellationToken);

        return Result.Success(response);
    }
}