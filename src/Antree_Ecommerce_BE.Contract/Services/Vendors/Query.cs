using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Enumerations;

namespace Antree_Ecommerce_BE.Contract.Services.Vendors;

public class Query
{
    public record GetVendorByIdQuery(string? VendorId, string? UserId) : IQuery<Response.VendorResponse>;
    public record GetVendorsQuery(string? SearchTerm, string? SortColumn, bool IsPending, SortOrder? SortOrder, int PageIndex, int PageSize) : IQuery<PagedResult<Response.VendorResponse>>;
}