using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Enumerations;
using Antree_Ecommerce_BE.Contract.Services.Products;
using Antree_Ecommerce_BE.Domain.Entities;
using Antree_Ecommerce_BE.Persistence;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Antree_Ecommerce_BE.Application.UserCases.Queries.Products;

public class GetProductsQueryHandler : IQueryHandler<Query.GetProductsQuery, PagedResult<Response.ProductResponse>>
{
    private readonly IMapper _mapper;
    private readonly ApplicationDbContext _context;
    
    public GetProductsQueryHandler(ApplicationDbContext context, IMapper mapper)
    {
        _mapper = mapper;
        _context = context;
    }
    
    public async Task<Result<PagedResult<Response.ProductResponse>>> Handle(Query.GetProductsQuery request, CancellationToken cancellationToken)
    {
        // if (request.SortColumnAndOrder.Any()) // =>>  Raw Query when order by multi column
        // {
            var pageIndex = request.PageIndex <= 0 ? PagedResult<Product>.DefaultPageIndex : request.PageIndex;
            var pageSize = request.PageSize <= 0
                ? PagedResult<Domain.Entities.Product>.DefaultPageSize
                : request.PageSize > PagedResult<Domain.Entities.Product>.UpperPageSize
                ? PagedResult<Domain.Entities.Product>.UpperPageSize : request.PageSize;

            // ============================================
            var productsQuery = string.IsNullOrWhiteSpace(request.SearchTerm)
                ? @$"SELECT * FROM {nameof(Domain.Entities.Product)} ORDER BY "
                : @$"SELECT * FROM {nameof(Domain.Entities.Product)}
                        WHERE {nameof(Domain.Entities.Product.Name)} LIKE '%{request.SearchTerm}%'
                        OR {nameof(Domain.Entities.Product.Description)} LIKE '%{request.SearchTerm}%'
                        ORDER BY ";

            
            if (request.SortColumnAndOrder.Any())
            {
                foreach (var item in request.SortColumnAndOrder)
                    productsQuery += item.Value == SortOrder.Descending
                        ? $"{item.Key} DESC, "
                        : $"{item.Key} ASC, ";
            }
            else
            {
                productsQuery += $"{nameof(Product.CreatedOnUtc)} DESC, ";
            }
            
            productsQuery = productsQuery.Remove(productsQuery.Length - 2);

            productsQuery += $" OFFSET {(pageIndex - 1) * pageSize} ROWS FETCH NEXT {pageSize} ROWS ONLY;";

            var products = await _context.Products.FromSqlRaw(productsQuery)
                .ToListAsync(cancellationToken: cancellationToken);

            var totalCount = await _context.Products.CountAsync(cancellationToken);

            var productPagedResult = PagedResult<Domain.Entities.Product>.Create(products,
                pageIndex,
                pageSize,
                totalCount);

            var result = _mapper.Map<PagedResult<Response.ProductResponse>>(productPagedResult);

            return Result.Success(result);
        //}
    }
}