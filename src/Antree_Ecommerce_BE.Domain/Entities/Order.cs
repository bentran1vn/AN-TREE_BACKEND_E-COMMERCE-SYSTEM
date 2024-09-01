using Antree_Ecommerce_BE.Domain.Abstractions.Entities;

namespace Antree_Ecommerce_BE.Domain.Entities;

public class Order : Entity<Guid>, IAuditableEntity
{
    public Guid? DiscountId { get; set; }
    public Guid UserId { get; set; }
    public string Address { get; set; }
    public string Note { get; set; }
    public decimal Total { get; set; }
    public int Status { get; set; }
    public DateTimeOffset CreatedOnUtc { get; set; }
    public DateTimeOffset? ModifiedOnUtc { get; set; }
    
    public IReadOnlyCollection<OrderDetail> OrderDetailList { get; set; } = default!;
}