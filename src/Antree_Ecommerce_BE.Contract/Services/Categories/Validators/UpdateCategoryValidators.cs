using FluentValidation;

namespace Antree_Ecommerce_BE.Contract.Services.Categories.Validators;

public class UpdateCategoryValidators : AbstractValidator<Command.UpdateCategoryCommand>
{
    public UpdateCategoryValidators()
    {
        RuleFor(x => x.CategoryId).NotEmpty();
    }
}