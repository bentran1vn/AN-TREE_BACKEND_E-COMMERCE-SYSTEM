using Ardalis.SmartEnum;

namespace Antree_Ecommerce_BE.Contract.Enumerations;

public class SortOrder : SmartEnum<SortOrder>
{
    public SortOrder(string name, int value)
        : base(name, value)
    {
    }

    public static readonly SortOrder Ascending = new(nameof(Ascending), 1);
    public static readonly SortOrder Descending = new(nameof(Descending), 2);

    public static implicit operator SortOrder(string name)
        => FromName(name);

    public static implicit operator SortOrder(int value)
        => FromValue(value);

    public static implicit operator string(SortOrder status)
        => status.Name;

    public static implicit operator int(SortOrder status)
        => status.Value;
}