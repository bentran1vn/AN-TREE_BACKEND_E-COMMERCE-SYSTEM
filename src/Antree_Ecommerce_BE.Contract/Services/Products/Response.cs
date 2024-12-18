namespace Antree_Ecommerce_BE.Contract.Services.Products;

public static class Response
{
    public record ProductsResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Sku { get; set; }
        public int Sold { get; set; }
        public decimal DiscountSold { get; set; }
        public decimal DiscountPercent { get; set; }
        public string CoverImage { get; set; }
        public decimal Rating { get; set; }
        public string VendorName { get; set; }
        public string VendorAvatarImage { get; set; }
    }
    
    //, string VendorName, string VendorAvatarImage
    
    public record ProductResponse(
        Guid Id, Guid ProductCategoryId, string Name,
        decimal Price, string Description, int Sku, int Sold,
        decimal DiscountSold, decimal DiscountPercent, string CoverImage,
        DateTimeOffset CreatedOnUtc, DateTimeOffset ModifiedOnUtc,
        Guid CreatedBy, Guid UpdatedBy, ProductCategory ProductCategory,
        Vendor Vendor, IReadOnlyCollection<ProductMedia> ProductImageList,
        IReadOnlyCollection<ProductFeedback> ProductFeedbackList
    );
    public class ProductCategory
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
    
    public class Vendor
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Phonenumber { get; set; }
        public string AvatarImage { get; set; }
        public string CoverImage { get; set; }
        public DateTimeOffset CreatedOnUtc { get; set; }
    }
    
    public class ProductMedia
    {
        public string ImageUrl { get; set; }
    }
    
    public class ProductFeedback
    {
        public int Rate { get; set; }
        public int Total { get; set; }
        
    }
}


