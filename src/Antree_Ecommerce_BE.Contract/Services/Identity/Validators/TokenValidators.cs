using FluentValidation;

namespace Antree_Ecommerce_BE.Contract.Services.Identity.Validators;

public class  TokenValidators : AbstractValidator<Query.Token>
{
    public TokenValidators()
    {
        RuleFor(x => x.AccessToken).NotEmpty();
        RuleFor(x => x.RefreshToken).NotEmpty();
    }
}