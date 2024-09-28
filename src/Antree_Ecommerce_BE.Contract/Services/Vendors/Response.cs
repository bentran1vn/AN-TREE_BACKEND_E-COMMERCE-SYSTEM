namespace Antree_Ecommerce_BE.Contract.Services.Vendors;

public class Response
{
    public record VendorResponse(
        Guid Id, string Name, string Email, string Address, string City,
        string Province, string Phonenumber, string BankName, string BankOwnerName,
        string BankAccountNumber, string AvatarImage, string CoverImage,
        DateTimeOffset CreatedOnUtc, DateTimeOffset ModifiedOnUtc
    );
}