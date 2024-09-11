using Antree_Ecommerce_BE.Contract.Abstractions.Messages;

namespace Antree_Ecommerce_BE.Contract.Services.Identity;

public static class Query
{
    public record Login(string Email, string Password) : IQuery<Response.Authenticated>;

    public record Token(string? AccessToken, string? RefreshToken) : IQuery<Response.Authenticated>;
}