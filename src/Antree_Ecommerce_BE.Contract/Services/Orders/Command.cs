using System.ComponentModel;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Swashbuckle.AspNetCore.Annotations;

namespace Antree_Ecommerce_BE.Contract.Services.Orders;

public static class Command
{
    public record CreateOrderCommand : ICommand
    {
        public List<OrderItems> OrderItems { get; set; } 
        
        [SwaggerSchema(ReadOnly = true)]
        [DefaultValue("e824c924-e441-4367-a03b-8dd13223f76f")]
        public Guid? UserId { get; set; } 
    }
    public record VerifyOrderCommand(Dictionary<string, string> vnpayData) : ICommand;
}

public class OrderItems
{
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
}