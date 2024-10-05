using System.ComponentModel;
using System.Text.Json.Serialization;
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
    
    public record UpdateProductDiscountCommand : ICommand 
    {
        [JsonPropertyName("productDiscountId")]
        public Guid ProductDiscountId { get; init; }

        [JsonPropertyName("name")]
        public string Name { get; init; }

        [JsonPropertyName("description")]
        public string Description { get; init; }

        [JsonPropertyName("discountPercent")]
        public decimal DiscountPercent { get; init; }

        [JsonPropertyName("startTime")]
        public DateTimeOffset StartTime { get; init; }

        [JsonPropertyName("endTime")]
        public DateTimeOffset EndTime { get; init; }

        [JsonPropertyName("isDeleted")]
        public bool IsDeleted { get; init; }

        [SwaggerSchema(ReadOnly = true)]
        [DefaultValue("e824c924-e441-4367-a03b-8dd13223f76f")]
        [JsonIgnore]
        public Guid VendorId { get; set; }
    }
}