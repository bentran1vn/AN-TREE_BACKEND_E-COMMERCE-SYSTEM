using System.ComponentModel;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Swashbuckle.AspNetCore.Annotations;

namespace Antree_Ecommerce_BE.Contract.Services.ProductDiscounts;

public static class Command
{
    public record CreateProductDiscountCommand(
        Guid ProductId, string Name, string Description,
        decimal DiscountPercent, DateTimeOffset StartTime, DateTimeOffset EndTime) : ICommand 
    {
        [SwaggerSchema(ReadOnly = true)]
        [DefaultValue("e824c924-e441-4367-a03b-8dd13223f76f")]
        public Guid VendorId { get; set; }
    }
}