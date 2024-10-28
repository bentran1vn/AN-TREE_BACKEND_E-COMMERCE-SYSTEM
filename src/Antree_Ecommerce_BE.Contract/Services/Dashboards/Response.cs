namespace Antree_Ecommerce_BE.Contract.Services.Dashboards;

public class Response
{
    public record GetOrderDashboard()
    {
        public int No { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public int OrderNumber { get; set; }
        public decimal TotalAmount { get; set; }
    }
    public record GetSubDashboard()
    {
        public int No { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public string SubscriptionName { get; set; }
        public string SubscriptionNumber { get; set; }
        public string SubscriptionTotal { get; set; }
    }
    public record GetAdminAmountDashboard(
        int TotalOrder, int TotalTransaction,
        int TotalVendor, int TotalCustomer);
}