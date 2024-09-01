using Antree_Ecommerce_BE.Domain.Abstractions.Entities;

namespace Antree_Ecommerce_BE.Domain.Entities;

public class Discount : Entity<Guid>, IAuditableEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal DiscountPercent { get; set; }
    public int Total { get; set; }
    public int Used { get; set; } = default!;
    public DateTimeOffset StartTime { get; set; }
    public DateTimeOffset EndTime { get; set; }
    public DateTimeOffset CreatedOnUtc { get; set; }
    public DateTimeOffset? ModifiedOnUtc { get; set; }
    
    public virtual IReadOnlyCollection<Order> OrderList { get; set; } = default!;
}