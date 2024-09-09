namespace Antree_Ecommerce_BE.Contract.Services.Feedbacks;

public class Response
{
    public record FeedbackResonse(
        Guid Id,
        DateTimeOffset CreatedOnUtc,
        OrderDetailFeedback OrderDetailFeedback,
        Order Order
    );

    public class OrderDetailFeedback
    {
        public string Content { get; set; }
        public int Rating { get; set; }
    }

    public class Order
    {
        public User User { get; set; }
    }

    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
    }
    
}