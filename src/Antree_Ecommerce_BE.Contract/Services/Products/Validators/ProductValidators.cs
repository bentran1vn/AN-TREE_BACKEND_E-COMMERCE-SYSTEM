using FluentValidation;

namespace Antree_Ecommerce_BE.Contract.Services.Products.Validators;

public class ProductValidators : AbstractValidator<Command.CreateProductCommand>
{
    public ProductValidators()
    {
        RuleFor(x => x.Name).NotEmpty();
        RuleFor(x => x.Description).NotEmpty();
        RuleFor(x => x.Price).NotEmpty();
        RuleFor(x => x.Sku).NotEmpty();
        RuleFor(x => x.Sold).LessThanOrEqualTo(0).NotNull();
        RuleFor(x => x.ProductCategoryId).NotEmpty();
        RuleFor(x => x.ProductImageCover).NotEmpty();
        RuleFor(x => x.ProductImages).NotEmpty();
    }
}