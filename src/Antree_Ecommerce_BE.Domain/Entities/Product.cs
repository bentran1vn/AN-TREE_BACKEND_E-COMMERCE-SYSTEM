using Antree_Ecommerce_BE.Domain.Abstractions.Entities;

namespace Antree_Ecommerce_BE.Domain.Entities;

public class Product : Entity<Guid>, IAuditableEntity
{
    private Product(string name, decimal price, string description, DateTimeOffset createdOnUtc, DateTimeOffset? modifiedOnUtc)
    {
        Name = name;
        Price = price;
        Description = description;
        CreatedOnUtc = createdOnUtc;
        ModifiedOnUtc = modifiedOnUtc;
    }

    public string Name { get; set; }

    public decimal Price { get; set; }

    public string Description { get; set; }
    
    public DateTimeOffset CreatedOnUtc { get; set; }
    
    public DateTimeOffset? ModifiedOnUtc { get; set; }
}