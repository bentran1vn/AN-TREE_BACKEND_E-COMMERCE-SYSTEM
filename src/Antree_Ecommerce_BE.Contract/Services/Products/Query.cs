using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Enumerations;

namespace Antree_Ecommerce_BE.Contract.Services.Products;

public static class Query
{
    public record GetProductQuery(string? SearchTerm, string? SortColumn, SortOrder? SortOrder, IDictionary<string, SortOrder>? SortColumnAndOrder) : IQuery<List<Response.ProductResponse>>;

    public record GetProductById(Guid Id) : IQuery<List<Response.ProductResponse>>;
}