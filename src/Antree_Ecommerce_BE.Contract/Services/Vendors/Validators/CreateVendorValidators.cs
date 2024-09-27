using FluentValidation;

namespace Antree_Ecommerce_BE.Contract.Services.Vendors.Validators;

public class CreateVendorValidators : AbstractValidator<Command.CreateVendorCommand>
{
    public CreateVendorValidators()
    {
        RuleFor(x => x.Address).NotEmpty();
        RuleFor(x => x.PhoneNumber).NotEmpty();
        RuleFor(x => x.Province).NotEmpty();
        RuleFor(x => x.VendorEmail).EmailAddress().NotEmpty();
        RuleFor(x => x.VendorName).NotEmpty();
        RuleFor(x => x.City).NotEmpty();
        RuleFor(x => x.AvatarImage).NotEmpty();
        RuleFor(x => x.CoverImage).NotEmpty();
        RuleFor(x => x.BankName).NotEmpty();
        RuleFor(x => x.BankAccountNumber).NotEmpty();
        RuleFor(x => x.BankOwnerName).NotEmpty();
    }
}