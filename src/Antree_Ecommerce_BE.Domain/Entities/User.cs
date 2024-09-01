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
    public string Role { get; set; }
    public DateTimeOffset CreatedOnUtc { get; set; }
    public DateTimeOffset? ModifiedOnUtc { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? UpdatedBy { get; set; }
    
    public IReadOnlyCollection<UserAddress> UserAddressList { get; set; } = default!;
    public IReadOnlyCollection<UserPayment> UserPaymentList { get; set; } = default!;
}