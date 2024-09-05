using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Categories;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Antree_Ecommerce_BE.Application.UserCases.Queries.Categories;

public class GetCategoriesQueryHandler : IQueryHandler<Query.GetCategoriesQuery, List<Response.CategoryResponse>>
{
    private readonly IRepositoryBase<Domain.Entities.ProductCategory, Guid> _productCategoryRepository;
    private readonly IMapper _mapper;

    public GetCategoriesQueryHandler(IRepositoryBase<ProductCategory, Guid> productCategoryRepository, IMapper mapper)
    {
        _productCategoryRepository = productCategoryRepository;
        _mapper = mapper;
    }

    public async Task<Result<List<Response.CategoryResponse>>> Handle(Query.GetCategoriesQuery request, CancellationToken cancellationToken)
    {
        var productCategories = await _productCategoryRepository.FindAll(null).ToListAsync();
        var result = _mapper.Map<List<Response.CategoryResponse>>(productCategories);
        return result;
    }
}