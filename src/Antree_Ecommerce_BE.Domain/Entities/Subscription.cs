using Antree_Ecommerce_BE.Domain.Abstractions.Entities;

namespace Antree_Ecommerce_BE.Domain.Entities;

public class Subscription : Entity<Guid>, IAuditableEntity
{
    public String Name { get; set; }
    public int Wait { get; set; }
    public decimal? Price { get; set; }
    public DateTimeOffset CreatedOnUtc { get; set; }
    public DateTimeOffset? ModifiedOnUtc { get; set; }
    
    public virtual IReadOnlyCollection<Transaction> TransactionList { get; set; } = default!;
}