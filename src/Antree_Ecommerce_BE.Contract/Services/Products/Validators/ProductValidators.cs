using FluentValidation;

namespace Antree_Ecommerce_BE.Contract.Services.Products.Validators;

public class ProductValidators : AbstractValidator<Command.CreateProductCommand>
{
    public ProductValidators()
    {
        RuleFor(x => x.Name).NotEmpty();
        RuleFor(x => x.Description).NotEmpty();
        RuleFor(x => x.Price).GreaterThanOrEqualTo(0).NotNull();
        RuleFor(x => x.Sku).GreaterThanOrEqualTo(0).NotNull();;
        RuleFor(x => x.Sold).GreaterThanOrEqualTo(0).NotNull();;
        RuleFor(x => x.ProductCategoryId).NotEmpty();
        RuleFor(x => x.VendorId).NotEmpty();
        RuleFor(x => x.ProductImageCover).NotEmpty();
        RuleFor(x => x.ProductImages).NotEmpty();
    }
}