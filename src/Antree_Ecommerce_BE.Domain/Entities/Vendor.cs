using Antree_Ecommerce_BE.Domain.Abstractions.Entities;

namespace Antree_Ecommerce_BE.Domain.Entities;

public class Vendor: Entity<Guid>, IAuditableEntity, ICreatedByEntity<Guid>, IUpdatedByEnity<Guid?>
{
    public string Email { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Province { get; set; }
    public string Phonenumber { get; set; }
    public string BankName { get; set; }
    public string BankOwnerName { get; set; }
    public string BankAccountNumber { get; set; }
    public string AvatarImage { get; set; }
    public string CoverImage { get; set; }
    
    public int Status { get; set; } // 0 Pending, 1 Working
    
    public virtual IReadOnlyCollection<Product> ProductList { get; set; } = default!;
    public DateTimeOffset CreatedOnUtc { get; set; }
    public DateTimeOffset? ModifiedOnUtc { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? UpdatedBy { get; set; }

    public Vendor(Guid id, string email, string name, string address, string city, string province,
        string phonenumber, string avatarImage, string coverImage, string bankName,string bankOwnerName,
        string bankAccountNumber, Guid createdBy, int status)
    {
        Id = id;
        Email = email;
        Name = name;
        Address = address;
        City = city;
        Province = province;
        Phonenumber = phonenumber;
        AvatarImage = avatarImage;
        CoverImage = coverImage;
        BankName = bankName;
        BankOwnerName = bankOwnerName;
        BankAccountNumber = bankAccountNumber;
        CreatedBy = createdBy;
        Status = status;
    }

    public void UpdateVendor(string email, string name, string address, string city, string province,
        string phonenumber, string avatarImage, string coverImage, string bankName,
        string bankOwnerName, string bankAccountNumber, Guid updateBy, bool isDeleted, int status)
    {
        Email = email;
        Name = name;
        Address = address;
        City = city;
        Province = province;
        Phonenumber = phonenumber;
        AvatarImage = avatarImage;
        CoverImage = coverImage;
        BankName = bankName;
        BankOwnerName = bankOwnerName;
        BankAccountNumber = bankAccountNumber;
        UpdatedBy = updateBy;
        IsDeleted = isDeleted;
        Status = status;
    }
    
    public void UpdateVendor(string email, string name, string address, string city, string province,
        string phonenumber, string avatarImage, string coverImage, string bankName,
        string bankOwnerName, string bankAccountNumber, Guid updateBy)
    {
        Email = email;
        Name = name;
        Address = address;
        City = city;
        Province = province;
        Phonenumber = phonenumber;
        AvatarImage = avatarImage;
        CoverImage = coverImage;
        BankName = bankName;
        BankOwnerName = bankOwnerName;
        BankAccountNumber = bankAccountNumber;
        UpdatedBy = updateBy;
    }
    
}