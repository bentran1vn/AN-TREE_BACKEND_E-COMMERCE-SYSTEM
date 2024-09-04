using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Products;
using Antree_Ecommerce_BE.Persistence;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Antree_Ecommerce_BE.Application.UserCases.Queries.Products;

public class GetProductByIdHandler : IQueryHandler<Query.GetProductByIdQuery, Response.ProductResponse>
{
    private readonly IMapper _mapper;
    private readonly ApplicationDbContext _context;
    
    public GetProductByIdHandler(ApplicationDbContext context, IMapper mapper)
    {
        _mapper = mapper;
        _context = context;
    }

    public async Task<Result<Response.ProductResponse>> Handle(Query.GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        var productsQuery = @$"SELECT * FROM {nameof(Domain.Entities.Product)}
                        WHERE {nameof(Domain.Entities.Product.Id)} = '{request.Id.ToString()}'";

        var productResult = await _context.Products.FromSqlRaw(productsQuery).FirstAsync(cancellationToken);
        
        var result = _mapper.Map<Response.ProductResponse>(productResult);

        return Result.Success(result);
    }
}