using Antree_Ecommerce_BE.Domain.Abstractions.Entities;

namespace Antree_Ecommerce_BE.Domain.Entities;

public class ProductFeedback: Entity<Guid>, IAuditableEntity
{
    public Guid ProductId { get; set; }
    public int Rate { get; set; }
    public int Total { get; set; }
    public DateTimeOffset CreatedOnUtc { get; set; }
    public DateTimeOffset? ModifiedOnUtc { get; set; }
    
    public virtual Product Product { get; set; } = default!;
}