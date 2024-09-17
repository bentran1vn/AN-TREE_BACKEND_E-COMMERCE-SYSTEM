using Antree_Ecommerce_BE.Domain.Abstractions.Entities;

namespace Antree_Ecommerce_BE.Domain.Entities;

public class OrderDetailFeedbackMedia : Entity<Guid>, IAuditableEntity
{
    public Guid OrderDetailFeedbackId { get; set; }
    public string ImageUrl { get; set; }
    public DateTimeOffset CreatedOnUtc { get; set; }
    public DateTimeOffset? ModifiedOnUtc { get; set; }
    
    public virtual OrderDetailFeedback OrderDetailFeedback { get; set; } = default!;
}