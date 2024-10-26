using System.Text.RegularExpressions;

namespace Antree_Ecommerce_BE.Application.DependencyInjection.Extensions;

public static class QrContentParser
{
    public static Guid GuidParser(string guidString)
    {
        if (guidString.Length != 32)
        {
            throw new FormatException("Invalid GUID format. GUID should be 32 characters long.");
        }

        // Insert hyphens to match the Guid format (8-4-4-4-12)
        string formattedOrderId = $"{guidString.Substring(0, 8)}-{guidString.Substring(8, 4)}-{guidString.Substring(12, 4)}-{guidString.Substring(16, 4)}-{guidString.Substring(20)}";

        // Parse the string back into a Guid
        return Guid.Parse(formattedOrderId);
    }

    public static QrParseResult ParseQrContent(string content)
    {
        // Regex pattern to match either AntreeOrder or AntreeSub followed by the ID
        Match match = Regex.Match(content, @"QR\s+Antree(Order|Sub)([a-zA-Z0-9]+)");

        if (!match.Success)
        {
            throw new FormatException("Invalid QR content format. Expected format: QR Antree[Order|Sub]<ID>");
        }

        return new QrParseResult
        {
            TransactionType = match.Groups[1].Value,  // Will be either "Order" or "Sub"
            TransactionId = match.Groups[2].Value     // Will be the ID portion
        };
    }

    public static (string type, Guid id) TakeOrderIdFromContent(string content)
    {
        var parseResult = ParseQrContent(content);
        
        // Validate if the extracted ID is a valid GUID (32 characters)
        if (parseResult.TransactionId.Length != 32)
        {
            throw new FormatException("Transaction ID must be 32 characters long.");
        }

        return (parseResult.TransactionType, GuidParser(parseResult.TransactionId));
    }
}

public class QrParseResult
{
    public string TransactionType { get; set; }
    public string TransactionId { get; set; }
}