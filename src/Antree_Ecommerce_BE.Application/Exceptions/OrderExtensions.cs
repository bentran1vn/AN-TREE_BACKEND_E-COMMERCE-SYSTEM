using System.Text.RegularExpressions;

namespace Antree_Ecommerce_BE.Application.Exceptions;

public static class OrderExtensions
{
    public static Guid GuidParser(string guidString)
    {
        string orderId = guidString;

        // Insert hyphens to match the Guid format (8-4-4-4-12)
        string formattedOrderId = $"{orderId.Substring(0, 8)}-{orderId.Substring(8, 4)}-{orderId.Substring(12, 4)}-{orderId.Substring(16, 4)}-{orderId.Substring(20)}";

        // Parse the string back into a Guid
        Guid guid = Guid.Parse(formattedOrderId);

        return guid;
    }
    
    public static Guid TakeOrderIdFromContent(string content)
    {
        var orderId = "";
        string note = content;
        Match match = Regex.Match(note, @"QR\s+([^\s]+)");  // Regular expression to match non-space characters after "QR"

        if (match.Success)
        {
            orderId = match.Groups[1].Value;
        }

        return GuidParser(orderId);
    }
    
}