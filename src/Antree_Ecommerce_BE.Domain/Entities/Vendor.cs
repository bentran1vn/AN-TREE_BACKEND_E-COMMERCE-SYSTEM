using Antree_Ecommerce_BE.Domain.Abstractions.Entities;

namespace Antree_Ecommerce_BE.Domain.Entities;

public class Vendor: Entity<Guid>, IAuditableEntity
{
    public string Email { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Province { get; set; }
    public string Phonenumber { get; set; }
    
    public virtual IReadOnlyCollection<Product> ProductList { get; set; } = default!;
    public DateTimeOffset CreatedOnUtc { get; set; }
    public DateTimeOffset? ModifiedOnUtc { get; set; }

    public Vendor(Guid id, string email, string name, string address, string city, string province, string phonenumber)
    {
        Id = id;
        Email = email;
        Name = name;
        Address = address;
        City = city;
        Province = province;
        Phonenumber = phonenumber;
    }
}