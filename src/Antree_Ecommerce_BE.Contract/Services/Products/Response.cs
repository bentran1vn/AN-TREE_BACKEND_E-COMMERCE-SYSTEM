namespace Antree_Ecommerce_BE.Contract.Services.Products;

public static class Response
{
    public record ProductResponse(
        Guid Id, Guid ProductCategoryId, string Name,
        decimal Price, string Description, int Sku, int Sold,
        DateTimeOffset CreatedOnUtc, DateTimeOffset ModifiedOnUtc,
        Guid CreatedBy, Guid UpdatedBy, ProductCategory ProductCategory
    );
    public class ProductCategory
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}


