namespace Antree_Ecommerce_BE.Contract.Services.ProductDiscounts;

public class Response
{
    public record GetProductDiscountsResponse(
        Guid Id, string Name, string Description, decimal DiscountPercent,
        DateTimeOffset StartTime, DateTimeOffset EndTime,
        DateTimeOffset CreatedOnUtc, bool IsDeleted);
    
    public record GetProductDiscountsesResponse(
        string Name, string Description, decimal DiscountPercent,
        DateTimeOffset StartTime, DateTimeOffset EndTime,
        DateTimeOffset CreatedOnUtc, bool IsDeleted);

    // public class Product
    // {
    //     public string ProductName { get; set; }
    //     public Guid ProductId { get; set; }
    //     public 
    // }
}