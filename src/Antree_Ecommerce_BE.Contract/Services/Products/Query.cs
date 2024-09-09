using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Enumerations;
using static Antree_Ecommerce_BE.Contract.Services.Products.Response;

namespace Antree_Ecommerce_BE.Contract.Services.Products;

public static class Query
{
    // public record GetProductsQuery(string? SearchTerm, Guid? CategoryId, string? SortColumn, SortOrder? SortOrder, IDictionary<string, SortOrder>? SortColumnAndOrder, int PageIndex, int PageSize) : IQuery<PagedResult<ProductResponse>>;
    public record GetProductsQuery(string? SearchTerm, Guid? CategoryId, string? SortColumn, SortOrder? SortOrder, int PageIndex, int PageSize) : IQuery<PagedResult<ProductResponse>>;
    public record GetProductByIdQuery(Guid Id) : IQuery<ProductResponse>;
}