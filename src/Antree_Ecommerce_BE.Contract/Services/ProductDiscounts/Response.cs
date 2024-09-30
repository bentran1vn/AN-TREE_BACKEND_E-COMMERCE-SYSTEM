namespace Antree_Ecommerce_BE.Contract.Services.ProductDiscounts;

public class Response
{
    public record GetProductDiscountsResponse(
        string Name, string Description, decimal DiscountPercent,
        DateTimeOffset StartTime, DateTimeOffset EndTime,
        DateTimeOffset CreatedOnUtc, bool IsDeleted);
}