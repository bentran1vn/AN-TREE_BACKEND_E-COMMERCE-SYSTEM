namespace Antree_Ecommerce_BE.Contract.Services.UserAddress;

public class Response
{
    public record GetAllUserAddress()
    {
        public Guid Id{ get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsOrder { get; set; }
        public DateTimeOffset CreatedOnUtc { get; set; }
    };
}