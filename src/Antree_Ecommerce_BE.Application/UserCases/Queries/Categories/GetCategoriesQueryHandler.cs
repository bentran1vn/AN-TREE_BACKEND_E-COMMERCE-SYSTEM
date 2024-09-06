using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Categories;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Antree_Ecommerce_BE.Application.UserCases.Queries.Categories;

public class GetCategoriesQueryHandler : IQueryHandler<Query.GetCategoriesQuery, ListResult<Response.CategoryResponse>>
{
    private readonly IRepositoryBase<Domain.Entities.ProductCategory, Guid> _productCategoryRepository;
    private readonly IMapper _mapper;

    public GetCategoriesQueryHandler(IRepositoryBase<ProductCategory, Guid> productCategoryRepository, IMapper mapper)
    {
        _productCategoryRepository = productCategoryRepository;
        _mapper = mapper;
    }

    public async Task<Result<ListResult<Response.CategoryResponse>>> Handle(Query.GetCategoriesQuery request, CancellationToken cancellationToken)
    {
        var productQuery =  _productCategoryRepository.FindAll(null);

        var products = await ListResult<ProductCategory>.CreateAsync(productQuery);
        
        var result = _mapper.Map<ListResult<Response.CategoryResponse>>(products);
        
        return result;
    }
}