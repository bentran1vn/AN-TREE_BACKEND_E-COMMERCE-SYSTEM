namespace Antree_Ecommerce_BE.Application.DependencyInjection.Extensions;

public class SePayBody
{
    public int id { get; set; }
    public string gateway { get; set; }
    public string transactionDate { get; set; }
    public string accountNumber { get; set; }
    public string code { get; set; }
    public string content { get; set; }
    public string transferType { get; set; }
    public int transferAmount { get; set; }
    public int accumulated { get; set; }
    public string subAccount { get; set; }
    public string referenceCode { get; set; }
    public string description { get; set; }
}