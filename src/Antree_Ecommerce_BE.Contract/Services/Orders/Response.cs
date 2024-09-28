namespace Antree_Ecommerce_BE.Contract.Services.Orders;

public class Response
{
    public record VendorOrdersResponse(
        Guid Id, string Address, string Note, decimal Total, int Status,
        bool IsFeedback, DateTimeOffset CreatedOnUtc, Discount Discount, User User
    );
    
    public record CustomerOrdersResponse(
        Guid Id, string Address, string Note, decimal Total, int Status,
        bool IsFeedback, DateTimeOffset CreatedOnUtc, Discount Discount
    );
    
    public class Discount
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal DiscountPercent { get; set; }
    }

    public class User
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phonenumber { get; set; }
    }
}

