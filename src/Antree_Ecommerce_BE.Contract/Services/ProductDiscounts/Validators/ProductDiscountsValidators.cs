using FluentValidation;

namespace Antree_Ecommerce_BE.Contract.Services.ProductDiscounts.Validators;

public class ProductDiscountsValidators : AbstractValidator<Command.CreateProductDiscountCommand>
{
    public ProductDiscountsValidators()
    {
        RuleFor(x => x.Name).NotEmpty();
        RuleFor(x => x.Description).NotEmpty();
        RuleFor(x => x.ProductId).NotEmpty();
        RuleFor(x => x.DiscountPercent).GreaterThanOrEqualTo(0).NotNull();;
        RuleFor(x => x.StartTime).LessThan(x=> x.EndTime).NotNull();;
        RuleFor(x => x.EndTime).NotEmpty();
    }
}