using Antree_Ecommerce_BE.Contract.Abstractions.Messages;

namespace Antree_Ecommerce_BE.Contract.Services.Orders;

public static class Command
{
    public record CreateOrderCommand(List<OrderItems> OrderItems) : ICommand;
}

public class OrderItems
{
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
}