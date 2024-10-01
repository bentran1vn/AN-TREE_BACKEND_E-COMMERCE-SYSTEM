using System.Linq.Expressions;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Enumerations;
using Antree_Ecommerce_BE.Contract.Services.Products;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;
using AutoMapper;


namespace Antree_Ecommerce_BE.Application.UserCases.Queries.Products;

public class GetProductsQueryHandler : IQueryHandler<Query.GetProductsQuery, PagedResult<Response.ProductsResponse>>
{
    private readonly IRepositoryBase<Product, Guid> _productRepository;
    private readonly IMapper _mapper;
    
    public GetProductsQueryHandler(IRepositoryBase<Product, Guid> productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }
    
    public async Task<Result<PagedResult<Response.ProductsResponse>>> Handle(Query.GetProductsQuery request, CancellationToken cancellationToken)
    {
        var productsQuery = string.IsNullOrWhiteSpace(request.SearchTerm)
            ? _productRepository.FindAll(null,
                x => x.Vendor,
                x => x.ProductFeedbackList)
            : _productRepository.FindAll(
                x => x.Name.ToLower().Contains(request.SearchTerm.ToLower())
                     || x.ProductCategory.Name.ToLower().Contains(request.SearchTerm.ToLower()),
                x => x.Vendor,
                x => x.ProductFeedbackList
            );
        
        TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
        var nowInVietnam = TimeZoneInfo.ConvertTime(DateTimeOffset.UtcNow, vietnamTimeZone).AddDays(-7);
        
        productsQuery = request.IsSale == false
            ? productsQuery
            : productsQuery.Where(x => x.ProductDiscountList
                .Any(productDiscount => !productDiscount.IsDeleted && productDiscount.CreatedOnUtc > nowInVietnam));
        
        productsQuery = string.IsNullOrWhiteSpace(request.CategoryName)
            ? productsQuery
            : productsQuery.Where(x => x.ProductCategory.Name.ToLower() == request.CategoryName.ToLower());
        
        productsQuery = string.IsNullOrWhiteSpace(request.VendorName)
            ? productsQuery
            : productsQuery.Where(x => x.Vendor.Name.ToLower() == request.VendorName.ToLower());
        
        productsQuery = request.SortOrder == SortOrder.Descending
            ? productsQuery.OrderByDescending(GetSortProperty(request))
            : productsQuery.OrderBy(GetSortProperty(request));

        var products = await PagedResult<Product>.CreateAsync(productsQuery,
            request.PageIndex,
            request.PageSize);

        var result = _mapper.Map<PagedResult<Response.ProductsResponse>>(products);
        return Result.Success(result);
    }
    
    private static Expression<Func<Product, object>> GetSortProperty(Query.GetProductsQuery request)
        => request.SortColumn?.ToLower() switch
        {
            "name" => product => product.Name,
            "price" => product => product.Price,
            "sold" => product => product.Sold,
            _ => product => product.Id
            //_ => product => product.CreatedDate // Default Sort Descending on CreatedDate column
        };
}