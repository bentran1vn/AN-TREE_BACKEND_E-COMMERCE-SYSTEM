using Antree_Ecommerce_BE.Domain.Abstractions.Entities;

namespace Antree_Ecommerce_BE.Domain.Entities;

public class OrderDetail :  Entity<Guid>, IAuditableEntity
{
    public Guid OrderId { get; set; }
    public Guid ProductId { get; set; }
    public Guid ProductQuantity { get; set; }
    public DateTimeOffset CreatedOnUtc { get; set; }
    public DateTimeOffset? ModifiedOnUtc { get; set; }

    public virtual Order Order { get; set; }
    public virtual Product Product { get; set; }
}