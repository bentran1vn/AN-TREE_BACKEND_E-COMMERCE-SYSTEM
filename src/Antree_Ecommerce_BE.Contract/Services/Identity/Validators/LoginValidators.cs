using FluentValidation;

namespace Antree_Ecommerce_BE.Contract.Services.Identity.Validators;

public class LoginValidators : AbstractValidator<Query.Login>
{
    public LoginValidators()
    {
        RuleFor(x => x.Email).EmailAddress();
        RuleFor(x => x.Password).NotEmpty();
    }
}