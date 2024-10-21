using Antree_Ecommerce_BE.Domain.Abstractions.Entities;

namespace Antree_Ecommerce_BE.Domain.Entities;

public class User : Entity<Guid>, IAuditableEntity, ICreatedByEntity<Guid>, IUpdatedByEnity<Guid?>
{
    public string Email { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Phonenumber { get; set; }
    public int Role { get; set; }
    public Guid? VendorId { get; set; }
    
    // public Guid? SubscriptionId { get; set; }
    public DateTimeOffset CreatedOnUtc { get; set; }
    public DateTimeOffset? ModifiedOnUtc { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? UpdatedBy { get; set; }
    public virtual Vendor? Vendor { get; set; } = default!;
    // public virtual Subscription? Subscription { get; set; } = default!;
    
    public virtual IReadOnlyCollection<UserAddress> UserAddressList { get; set; } = default!;
    public virtual IReadOnlyCollection<UserPayment> UserPaymentList { get; set; } = default!;
}