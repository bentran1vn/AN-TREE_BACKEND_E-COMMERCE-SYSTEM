using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Products;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Persistence;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Antree_Ecommerce_BE.Application.UserCases.Queries.Products;

public class GetProductByIdHandler : IQueryHandler<Query.GetProductByIdQuery, Response.ProductResponse>
{
    private readonly IRepositoryBase<Domain.Entities.Product, Guid> _productRepository;
    private readonly IMapper _mapper;
    public GetProductByIdHandler(IRepositoryBase<Domain.Entities.Product, Guid> productRepository, IMapper mapper)
    {
        _mapper = mapper;
        _productRepository = productRepository;
    }

    public async Task<Result<Response.ProductResponse>> Handle(Query.GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        var product = await _productRepository.FindSingleAsync(
            x => x.Id.Equals(request.Id),
            cancellationToken,
            x => x.ProductCategory,
            x => x.ProductImageList,
            x => x.ProductFeedbackList
        );
        
        var result = _mapper.Map<Response.ProductResponse>(product);

        return Result.Success(result);
    }
}