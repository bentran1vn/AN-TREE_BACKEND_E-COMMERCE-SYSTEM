using FluentValidation;

namespace Antree_Ecommerce_BE.Contract.Services.Identity.Validators;

public class LogoutValidators : AbstractValidator<Command.LogoutCommand>
{
    public LogoutValidators()
    {
        RuleFor(x => x.UserAccount).NotEmpty();
    }
}