using Antree_Ecommerce_BE.Contract.Abstractions.Messages;

namespace Antree_Ecommerce_BE.Contract.Services.ProductDiscounts;

public static class Command
{
    public record CreateProductDiscountCommand(
        Guid ProductId, string Name, string Description,
        decimal DiscountPercent, DateTimeOffset StartTime, DateTimeOffset EndTime) : ICommand;
}