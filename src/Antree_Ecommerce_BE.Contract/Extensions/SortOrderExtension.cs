using Antree_Ecommerce_BE.Contract.Enumerations;

namespace Antree_Ecommerce_BE.Contract.Extensions;

public static class SortOrderExtension
{
    public static SortOrder ConvertStringToSortOrder(string? sortOrder)
        => !string.IsNullOrWhiteSpace(sortOrder)
            ? sortOrder.ToUpper().Equals("ASC")
                ? SortOrder.Ascending : SortOrder.Descending : SortOrder.Descending;

    // Format: Column1-ASC,Column2-DESC...
    public static IDictionary<string, SortOrder> ConvertStringToSortOrderV2(string? sortOrder)
    {
        var result = new Dictionary<string, SortOrder>();

        if (!string.IsNullOrEmpty(sortOrder))
        {
            if (sortOrder.Trim().Split(",").Length > 0)
            {
                foreach (var item in sortOrder.Split(","))
                {
                    if (!item.Contains('-'))
                        throw new FormatException("Sort condition should be follow by format: Column1-ASC,Column2-DESC...");
                    var property = item.Trim().Split("-");
                    var key = ProductExtension.GetSortProductProperty(property[0]);
                    var value = ConvertStringToSortOrder(property[1]);
                    result.TryAdd(key, value);
                }
            }
            else
            {
                if (!sortOrder.Contains('-'))
                    throw new FormatException("Sort condition should be follow by format: Column1-ASC,Column2-DESC...");

                var property = sortOrder.Trim().Split("-");
                result.Add(property[0], ConvertStringToSortOrder(property[1]));
            }
        }

        return result;
    }
}