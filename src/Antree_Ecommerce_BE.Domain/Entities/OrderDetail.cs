using Antree_Ecommerce_BE.Domain.Abstractions.Entities;

namespace Antree_Ecommerce_BE.Domain.Entities;

public class OrderDetail :  Entity<Guid>, IAuditableEntity
{
    public Guid OrderId { get; set; }
    public Guid ProductId { get; set; }
    public Guid? OrderDetailFeedbackId { get; set; }
    public int ProductQuantity { get; set; }
    public decimal ProductPrice { get; set; }
    public decimal ProductPriceDiscount { get; set; }
    public DateTimeOffset CreatedOnUtc { get; set; }
    public DateTimeOffset? ModifiedOnUtc { get; set; }

    public virtual Order Order { get; set; } = default!;
    public virtual Product Product { get; set; } = default!;
    public virtual OrderDetailFeedback? OrderDetailFeedback { get; set; } = default!;
}