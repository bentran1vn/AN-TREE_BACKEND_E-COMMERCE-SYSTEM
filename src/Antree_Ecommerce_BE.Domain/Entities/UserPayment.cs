using Antree_Ecommerce_BE.Domain.Abstractions.Entities;

namespace Antree_Ecommerce_BE.Domain.Entities;

public class UserPayment : Entity<Guid>, IAuditableEntity
{
    public Guid UserId { get; set; }
    public string PaymentType { get; set; }
    public string Provider { get; set; }
    public string CardNumber { get; set; }
    public string Cvc { get; set; }
    public bool IsOrder { get; set; }
    public DateTimeOffset Expire { set; get; }
    public DateTimeOffset CreatedOnUtc { get; set; }
    public DateTimeOffset? ModifiedOnUtc { get; set; }
    
    public virtual User User { get; set; } = default!;
}