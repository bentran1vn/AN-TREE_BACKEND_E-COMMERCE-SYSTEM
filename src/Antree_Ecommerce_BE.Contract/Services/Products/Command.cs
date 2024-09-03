using Antree_Ecommerce_BE.Contract.Abstractions.Messages;

namespace Antree_Ecommerce_BE.Contract.Services.Products;

public static class Command
{
    public record CreateProductCommand(Guid ProductCategoryId, string Name, decimal Price, string Description, int Sku, int Sold) : ICommand;

    public record UpdateProductCommand(Guid Id, Guid ProductCategoryId, string Name, decimal Price, string Description, int Sku, int Sold) : ICommand;

    public record DeleteProductCommand(Guid Id) : ICommand;
}