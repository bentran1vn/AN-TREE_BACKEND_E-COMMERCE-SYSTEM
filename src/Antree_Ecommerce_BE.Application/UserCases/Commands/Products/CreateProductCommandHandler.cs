using Antree_Ecommerce_BE.Application.Abstractions;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Products;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;

namespace Antree_Ecommerce_BE.Application.UserCases.Commands.Products;

public sealed class CreateProductCommandHandler : ICommandHandler<Command.CreateProductCommand>
{
    private readonly IRepositoryBase<Product, Guid> _productRepository;
    private readonly ICacheService _cacheService;

    public CreateProductCommandHandler(IRepositoryBase<Product, Guid> productRepository, ICacheService cacheService)
    {
        _productRepository = productRepository;
        _cacheService = cacheService;
    }

    public async Task<Result> Handle(Command.CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = Product.CreateProduct(
            Guid.NewGuid(), 
            request.ProductCategoryId, request.Name, request.Price,
            request.Description, request.Sku, request.Sold,
            Guid.NewGuid(), Guid.Empty
        );
        _productRepository.Add(product);

        await _cacheService.RemoveByPrefixAsync($"{nameof(Query.GetProductsQuery)}", cancellationToken);

        return Result.Success();
    }
}