using Ardalis.SmartEnum;

namespace Antree_Ecommerce_BE.Domain.Enumerations;

public class OrderStatus : SmartEnum<OrderStatus>
{
    public OrderStatus(string name, int value) : base(name, value)
    {
    }

    public static readonly OrderStatus Pending = new(nameof(Pending), 0);
    public static readonly OrderStatus Finish = new(nameof(Finish), 1);
    
    public static implicit operator OrderStatus(string name)
        => FromName(name);

    public static implicit operator OrderStatus(int value)
        => FromValue(value);

    public static implicit operator string(OrderStatus status)
        => status.Name;

    public static implicit operator int(OrderStatus status)
        => status.Value;
}