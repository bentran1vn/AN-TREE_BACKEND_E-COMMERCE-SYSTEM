using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Enumerations;

namespace Antree_Ecommerce_BE.Contract.Services.ProductDiscounts;

public class Query
{
    public record GetProductDiscountsQuery(
        Guid ProductId,
        Guid VendorId,
        bool IsRelease,
        string? SortColumn,
        SortOrder? SortOrder,
        int PageIndex,
        int PageSize) : IQuery<PagedResult<Response.GetProductDiscountsResponse>>;
}