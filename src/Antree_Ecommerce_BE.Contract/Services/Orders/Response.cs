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

    public record OrderResponse(
        Guid Id, string Address, string Note, decimal Total, int Status,
        bool IsFeedback, DateTimeOffset CreatedOnUtc, Discount? Discount,
        IReadOnlyCollection<OrderDetail> OrderDetails);
    
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

    public class OrderDetail
    {
        public Guid Id { get; set; }
        public int ProductQuantity { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ProductPriceDiscount { get; set; }
        // public Product Product { get; set; } = default!;
        public OrderDetailFeedback? OrderDetailFeedback { get; set; } 
    }
    
    public class OrderDetailFeedback
    {
        public string Content { get; set; }
        public int Rating { get; set; }
        public DateTimeOffset CreatedOnUtc { get; set; }
        public IReadOnlyCollection<string> OrderDetailFeedbackMedia { get; set; }
    }
}

