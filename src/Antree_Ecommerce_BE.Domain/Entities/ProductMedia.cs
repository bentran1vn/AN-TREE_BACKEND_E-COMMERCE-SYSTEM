using Antree_Ecommerce_BE.Domain.Abstractions.Entities;

namespace Antree_Ecommerce_BE.Domain.Entities;

public class ProductMedia : Entity<Guid>, IAuditableEntity
{
    public Guid ProductId { get; set; }
    
    public string ImageUrl { get; set; }
    public DateTimeOffset CreatedOnUtc { get; set; }
    public DateTimeOffset? ModifiedOnUtc { get; set; }
    
    public virtual Product Product { get; set; } = default!;
}