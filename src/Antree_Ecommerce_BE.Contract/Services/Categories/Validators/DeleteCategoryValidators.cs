using FluentValidation;

namespace Antree_Ecommerce_BE.Contract.Services.Categories.Validators;

public class DeleteCategoryValidators : AbstractValidator<Command.DeleteCategoryCommand>
{
    public DeleteCategoryValidators()
    {
        RuleFor(x => x.CategoryId).NotEmpty();
    }
}