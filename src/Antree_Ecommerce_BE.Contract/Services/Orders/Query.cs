using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Enumerations;

namespace Antree_Ecommerce_BE.Contract.Services.Orders;

public static class Query
{
    public record GetVendorOrdersQuery(Guid VendorId , bool NotFeedback, string? SortColumn, SortOrder? SortOrder, int PageIndex, int PageSize) : IQuery<PagedResult<Response.VendorOrdersResponse>>;
    public record GetCustomerOrdersQuery(Guid CustomerId, bool NotFeedback, string? SortColumn, SortOrder? SortOrder, int PageIndex, int PageSize) : IQuery<PagedResult<Response.CustomerOrdersResponse>>;
    public record GetOrderQuery(Guid Id) : IQuery<Response.OrderResponse>;
}