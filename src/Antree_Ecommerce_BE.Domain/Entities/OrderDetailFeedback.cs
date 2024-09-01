using Antree_Ecommerce_BE.Domain.Abstractions.Entities;

namespace Antree_Ecommerce_BE.Domain.Entities;

public class OrderDetailFeedback : Entity<Guid>, IAuditableEntity
{
    public Guid OrderDetailId { get; set; }
    public string Content { get; set; }
    public int Rating { get; set; }
    public DateTimeOffset CreatedOnUtc { get; set; }
    public DateTimeOffset? ModifiedOnUtc { get; set; }
    
    public virtual OrderDetail OrderDetail { get; set; } = default!;
}