using System.Security.Claims;

namespace Antree_Ecommerce_BE.Application.Abstractions;

public interface IJwtTokenService
{
    string GenerateAccessToken(IEnumerable<Claim> claims);
    string GenerateRefreshToken();
    (ClaimsPrincipal, bool) GetPrincipalFromExpiredToken(string token);
}