using System.Text;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Enumerations;
using static Antree_Ecommerce_BE.Contract.Services.Products.Response;

namespace Antree_Ecommerce_BE.Contract.Services.Products;

public static class Query
{
    // public record GetProductsQuery(string? SearchTerm, Guid? CategoryId, string? SortColumn, SortOrder? SortOrder, IDictionary<string, SortOrder>? SortColumnAndOrder, int PageIndex, int PageSize) : IQuery<PagedResult<ProductResponse>>;
    public record GetProductsQuery : IQuery<PagedResult<ProductResponse>>, ICacheable
    {
        public GetProductsQuery(string? searchTerm, Guid? categoryId, string? sortColumn, bool? isSale, SortOrder? sortOrder, int pageIndex, int pageSize)
        {
            SearchTerm = searchTerm;
            CategoryId = categoryId;
            SortColumn = sortColumn;
            IsSale = isSale;
            SortOrder = sortOrder;
            PageIndex = pageIndex;
            PageSize = pageSize;
        }

        public string? SearchTerm { get; init; }
        public Guid? CategoryId { get; init; }
        public string? SortColumn { get; init; }
        
        public bool? IsSale { get; init; }
        public SortOrder? SortOrder { get; init; }
        public int PageIndex { get; init; }
        public int PageSize { get; init; }
        public bool BypassCache => true;
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
                if (CategoryId.HasValue)
                {
                    builder.Append($"-CategoryId:{CategoryId}");
                }
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