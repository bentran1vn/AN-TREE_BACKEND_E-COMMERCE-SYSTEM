using Antree_Ecommerce_BE.Domain.Abstractions.Entities;

namespace Antree_Ecommerce_BE.Domain.Entities;

public class Transaction : Entity<Guid>, IAuditableEntity
{
    public decimal Total { get; set; }
    public string Note { get; set; }
    public Guid UserId { get; set; }
    public virtual User User { get; set; } = default!;
    public Guid SubscriptionId { get; set; }
    public virtual Subscription Subscription { get; set; } = default!;
    public int Status { get; set; }
    public DateTimeOffset CreatedOnUtc { get; set; }
    public DateTimeOffset? ModifiedOnUtc { get; set; }
}