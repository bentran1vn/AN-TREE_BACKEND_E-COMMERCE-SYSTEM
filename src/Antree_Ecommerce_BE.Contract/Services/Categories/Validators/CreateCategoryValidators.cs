using FluentValidation;

namespace Antree_Ecommerce_BE.Contract.Services.Categories.Validators;

public class CreateCategoryValidators : AbstractValidator<Command.CreateCategoryCommand>
{
    public CreateCategoryValidators()
    {
        RuleFor(x => x.Name).NotEmpty();
        RuleFor(x => x.Description).NotEmpty();
    }
}