using Antree_Ecommerce_BE.Contract.Abstractions.Messages;

namespace Antree_Ecommerce_BE.Contract.Services.Dashboards;

public class Query
{
    public record GetOrderDashboardQuery(string? VendorId, string? Month, string? Year) : IQuery<List<Response.GetOrderDashboard>>;
    public record GetSubDashboardQuery(string? Month, string? Year) : IQuery<List<Response.GetSubDashboard>>;
    public record GetAdminAmountDashboardQuery() : IQuery<Response.GetAdminAmountDashboard>;
}