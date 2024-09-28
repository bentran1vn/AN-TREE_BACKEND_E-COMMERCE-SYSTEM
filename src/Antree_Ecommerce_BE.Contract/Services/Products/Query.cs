using System.Text;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Enumerations;
using static Antree_Ecommerce_BE.Contract.Services.Products.Response;

namespace Antree_Ecommerce_BE.Contract.Services.Products;

public static class Query
{
    // public record GetProductsQuery(string? SearchTerm, Guid? CategoryId, string? SortColumn, SortOrder? SortOrder, IDictionary<string, SortOrder>? SortColumnAndOrder, int PageIndex, int PageSize) : IQuery<PagedResult<ProductResponse>>;
    public record GetProductsQuery : IQuery<PagedResult<ProductsResponse>>, ICacheable
    {
        public GetProductsQuery(string? searchTerm, string? categoryName, string? sortColumn, bool isSale, SortOrder? sortOrder, string? vendorName  , int pageIndex, int pageSize)
        {
            SearchTerm = searchTerm;
            CategoryName = categoryName;
            VendorName = vendorName;
            SortColumn = sortColumn;
            IsSale = isSale;
            SortOrder = sortOrder;
            PageIndex = pageIndex;
            PageSize = pageSize;
        }

        public string? SearchTerm { get; init; }
        public string? CategoryName { get; init; }
        public string? SortColumn { get; init; }
        public bool IsSale { get; init; }
        public SortOrder? SortOrder { get; init; }
        public string? VendorName { get; init; }
        public int PageIndex { get; init; }
        public int PageSize { get; init; }
        public bool BypassCache => false;
        public string CacheKey
        {
            get
            {
                var builder = new StringBuilder();
                builder.Append($"{nameof(GetProductsQuery)}");
                if (SearchTerm != null)
                {
                    builder.Append($"-SearchTerm:{SearchTerm}");
                }
                if (CategoryName != null)
                {
                    builder.Append($"-CategoryName:{CategoryName}");
                }
                if (VendorName != null)
                {
                    builder.Append($"-VendorName:{VendorName}");
                }
                builder.Append($"-IsSale:{IsSale}");
                builder.Append($"-Sort:{SortColumn}:{SortOrder}");
                builder.Append($"-Page:{PageIndex}:{PageSize}");
                return builder.ToString();
            }
        }

        public int SlidingExpirationInMinutes => 30;
        public int AbsoluteExpirationInMinutes => 60;
    }

    public record GetProductByIdQuery(Guid Id) : IQuery<ProductResponse>;
}