using Antree_Ecommerce_BE.Application.Abstractions;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Products;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Exceptions;

namespace Antree_Ecommerce_BE.Application.UserCases.Commands.Products;

public sealed class DeleteProductCommandHandler : ICommandHandler<Command.DeleteProductCommand>
{
    private readonly IRepositoryBase<Domain.Entities.Product, Guid> _productRepository;
    private readonly ICacheService _cacheService;

    public DeleteProductCommandHandler(IRepositoryBase<Domain.Entities.Product, Guid> productRepository, ICacheService cacheService)
    {
        _productRepository = productRepository;
        _cacheService = cacheService;
    }

    public async Task<Result> Handle(Command.DeleteProductCommand request, CancellationToken cancellationToken)
    {
        var product = await _productRepository.FindByIdAsync(request.Id, cancellationToken) ?? throw new ProductException.ProductNotFoundException(request.Id);
        if (!product.VendorId.Equals(request.VendorId))
        {
            return Result.Failure(new Error("403", "Can Only Remove Your Product !"));
        }
        _productRepository.Remove(product);
        
        await _cacheService.RemoveByPrefixAsync($"{nameof(Query.GetProductsQuery)}", cancellationToken);
        
        return Result.Success();
    }
}