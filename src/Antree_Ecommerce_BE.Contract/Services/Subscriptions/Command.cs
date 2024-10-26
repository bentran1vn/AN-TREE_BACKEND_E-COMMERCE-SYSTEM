using System.ComponentModel;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Swashbuckle.AspNetCore.Annotations;

namespace Antree_Ecommerce_BE.Contract.Services.Subscriptions;

public static class Command
{
    public record BuySubscriptionsCommand(): ICommand
    {
        [SwaggerSchema(ReadOnly = true)]
        [DefaultValue("e824c924-e441-4367-a03b-8dd13223f76f")]
        public Guid UserId { get; set; }
        
        public Guid SubscriptionId { get; set; }
    }
    
    public record CreateSePayTranCommand : ICommand
    {
        public Guid transactionId { get; set; }
        public string transactionDate { get; set; }
        public int transferAmount { get; set; }
    };
}