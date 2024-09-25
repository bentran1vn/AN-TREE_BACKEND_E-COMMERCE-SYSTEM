using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Microsoft.AspNetCore.Http;

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

    public record UpdateProductCommand(Guid Id, Guid ProductCategoryId, string Name, decimal Price, string Description, int Sku, int Sold) : ICommand;

    public record DeleteProductCommand(Guid Id) : ICommand;
}