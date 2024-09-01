using Antree_Ecommerce_BE.Domain.Abstractions.Entities;

namespace Antree_Ecommerce_BE.Domain.Entities;

public class OrderPayment :  Entity<Guid>, IAuditableEntity
{
    public Guid OrderId { get; set; }
    public string CardNumber { get; set; }
    public string Cvc { get; set; }
    public string Expire { set; get; }
    public DateTimeOffset CreatedOnUtc { get; set; }
    public DateTimeOffset? ModifiedOnUtc { get; set; }
}