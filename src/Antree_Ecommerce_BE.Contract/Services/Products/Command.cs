using System.ComponentModel;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Annotations;

namespace Antree_Ecommerce_BE.Contract.Services.Products;

public static class Command
{
    public record CreateProductCommand : ICommand
    {
        public Guid ProductCategoryId { get; set; }
        public Guid VendorId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Sku { get; set; }
        public int Sold { get; set; }
        
        public IFormFile ProductImageCover { get; set; }
        
        public IFormFileCollection ProductImages { get; set; }
    };

    public record UpdateProductCommand : ICommand
    {
        public Guid Id { get; set; }
        [SwaggerSchema(ReadOnly = true)]
        [DefaultValue("e824c924-e441-4367-a03b-8dd13223f76f")]
        public Guid VendorId { get; set; }
        public Guid? ProductCategoryId { get; set; }
        public string? Name { get; set; }
        public decimal? Price { get; set; }
        public string? Description { get; set; }
        public int? Sku { get; set; }
        // public IFormFile? ProductImageCover { get; set; }
        // public IFormFileCollection? ProductImages { get; set; }
    };

    public record DeleteProductCommand(Guid Id, Guid VendorId) : ICommand;
}