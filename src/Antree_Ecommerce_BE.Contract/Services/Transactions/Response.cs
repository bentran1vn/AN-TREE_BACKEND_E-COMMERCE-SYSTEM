namespace Antree_Ecommerce_BE.Contract.Services.Transactions;

public class Response
{
    public record GetAllTransaction()
    {
        public Guid Id{ get; set; }
        public String Email{ get; set; }
        public String SubscriptionName{ get; set; }
        public Decimal Total{ get; set; }
        public int Status{ get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    };
}