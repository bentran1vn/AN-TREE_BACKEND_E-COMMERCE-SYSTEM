using System.Linq.Expressions;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Enumerations;
using Antree_Ecommerce_BE.Contract.Services.Products;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Antree_Ecommerce_BE.Application.UserCases.Queries.Products;

public class GetProductsQueryHandler : IQueryHandler<Query.GetProductsQuery, PagedResult<Response.ProductResponse>>
{
    private readonly IRepositoryBase<Product, Guid> _productRepository;
    private readonly IMapper _mapper;
    
    public GetProductsQueryHandler(IRepositoryBase<Product, Guid> productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }
    
    public async Task<Result<PagedResult<Response.ProductResponse>>> Handle(Query.GetProductsQuery request, CancellationToken cancellationToken)
    {
        var productsQuery = string.IsNullOrWhiteSpace(request.SearchTerm)
            ? _productRepository.FindAll(null)
            : _productRepository.FindAll(x => x.Name.Contains(request.SearchTerm) || x.ProductCategory.Name.Contains(request.SearchTerm));

        productsQuery = productsQuery
            .Include(x=> x.ProductCategory)
            .Include(x => x.ProductImageList);
        
        productsQuery = request.IsSale == null
            ? productsQuery
            : request.IsSale == true ? 
                productsQuery.Where(x => x.ProductDiscountList
                .Any(x => !x.IsDeleted && x.CreatedOnUtc > DateTimeOffset.Now.AddDays(-7) ))
                : productsQuery ;
        
        productsQuery = request.CategoryId == null
            ? productsQuery
            : productsQuery.Where(x => x.ProductCategory.Id.Equals(request.CategoryId));
        
        productsQuery = request.SortOrder == SortOrder.Descending
            ? productsQuery.OrderByDescending(GetSortProperty(request))
            : productsQuery.OrderBy(GetSortProperty(request));

        var products = await PagedResult<Product>.CreateAsync(productsQuery,
            request.PageIndex,
            request.PageSize);

        var result = _mapper.Map<PagedResult<Response.ProductResponse>>(products);
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