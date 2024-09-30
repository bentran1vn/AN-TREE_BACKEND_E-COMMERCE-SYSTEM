using System.Linq.Expressions;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Enumerations;
using Antree_Ecommerce_BE.Contract.Services.ProductDiscounts;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;
using AutoMapper;

namespace Antree_Ecommerce_BE.Application.UserCases.Queries.ProductDiscounts;

public class GetProductDiscountsQueryHandler : IQueryHandler<Query.GetProductDiscountsQuery, PagedResult<Response.GetProductDiscountsResponse>>
{
    private readonly IRepositoryBase<ProductDiscount, Guid> _productDiscountRepository;
    private readonly IMapper _mapper;

    public GetProductDiscountsQueryHandler(IRepositoryBase<ProductDiscount, Guid> productDiscountRepository, IMapper mapper)
    {
        _productDiscountRepository = productDiscountRepository;
        _mapper = mapper;
    }

    public async Task<Result<PagedResult<Response.GetProductDiscountsResponse>>> Handle(Query.GetProductDiscountsQuery request, CancellationToken cancellationToken)
    {
        var query = _productDiscountRepository.FindAll(
            x => x.ProductId.Equals(request.ProductId)
                && x.Product.VendorId.Equals(request.VendorId)
        );
        
        query = request.IsRelease
            ? query.Where(x => !x.IsDeleted)
            : query;
        
        query = request.SortOrder == SortOrder.Descending
            ? query.OrderByDescending(GetSortProperty(request))
            : query.OrderBy(GetSortProperty(request));

        var products = await PagedResult<ProductDiscount>.CreateAsync(query,
            request.PageIndex,
            request.PageSize);
        
        var result = _mapper.Map<PagedResult<Response.GetProductDiscountsResponse>>(products);
        
        return Result.Success(result);
    }
    
    private static Expression<Func<ProductDiscount, object>> GetSortProperty(Query.GetProductDiscountsQuery request)
        => request.SortColumn?.ToLower() switch
        {
            "name" => discount => discount.Name,
            "percent" => discount => discount.DiscountPercent,
            _ => vendor => vendor.Id
            //_ => product => product.CreatedDate // Default Sort Descending on CreatedDate column
        };
}