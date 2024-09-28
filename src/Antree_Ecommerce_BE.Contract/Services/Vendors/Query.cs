using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Enumerations;

namespace Antree_Ecommerce_BE.Contract.Services.Vendors;

public class Query
{
    public record GetVendorByIdQuery(Guid VendorId) : IQuery<Response.VendorResponse>;
    public record GetVendorsQuery(string? SearchTerm, string? SortColumn, SortOrder? SortOrder, int PageIndex, int PageSize) : IQuery<PagedResult<Response.VendorResponse>>;
}