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
    
    
    public record CreateSePayOrderCommand : ICommand
    {
        public int id { get; set; }
        public string gateway { get; set; }
        public string transactionDate { get; set; }
        public string accountNumber { get; set; }
        public string code { get; set; }
        public string content { get; set; }
        public string transferType { get; set; }
        public int transferAmount { get; set; }
        public int accumulated { get; set; }
        public string subAccount { get; set; }
        public string referenceCode { get; set; }
        public string description { get; set; }
    }
    
    public record VerifyOrderCommand(Dictionary<string, string> vnpayData) : ICommand;
}

public class OrderItems
{
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
}