using Antree_Ecommerce_BE.Domain.Abstractions.Entities;

namespace Antree_Ecommerce_BE.Domain.Entities;

public class Product : Entity<Guid>, IAuditableEntity
{
    public string Name { get; set; }

    public decimal Price { get; set; }

    public string Description { get; set; }
    
    public DateTimeOffset CreatedOnUtc { get; set; }
    
    public DateTimeOffset? ModifiedOnUtc { get; set; }
}