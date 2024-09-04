namespace Antree_Ecommerce_BE.Contract.Extensions;

public static class ProductExtension
{
    public static string GetSortProductProperty(string sortColumn)
        => sortColumn.ToLower() switch
        {
            "name" => "Name",
            "price" => "Price",
            "description" => "Description",
            _ => "Id"
        };
}