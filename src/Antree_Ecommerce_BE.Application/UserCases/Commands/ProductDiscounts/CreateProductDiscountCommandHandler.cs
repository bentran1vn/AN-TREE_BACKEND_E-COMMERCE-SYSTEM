using Antree_Ecommerce_BE.Application.Abstractions;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.ProductDiscounts;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Query = Antree_Ecommerce_BE.Contract.Services.Products.Query;

namespace Antree_Ecommerce_BE.Application.UserCases.Commands.ProductDiscounts;

public class CreateProductDiscountCommandHandler : ICommandHandler<Command.CreateProductDiscountCommand>
{
    private readonly IRepositoryBase<ProductDiscount, Guid> _productDiscountRepository;
    private readonly IRepositoryBase<Product, Guid> _productRepository;
    private readonly ICacheService _cacheService;

    public CreateProductDiscountCommandHandler(IRepositoryBase<ProductDiscount, Guid> productDiscountRepository, IRepositoryBase<Product, Guid> productRepository, ICacheService cacheService)
    {
        _productDiscountRepository = productDiscountRepository;
        _productRepository = productRepository;
        _cacheService = cacheService;
    }


    public async Task<Result> Handle(Command.CreateProductDiscountCommand request, CancellationToken cancellationToken)
    {
        var productDiscounts = await _productDiscountRepository
            .FindAll(x => x.ProductId.Equals(request.ProductId) && x.IsDeleted == false)
            .ToListAsync(cancellationToken: cancellationToken);

        var product = await _productRepository.FindByIdAsync(request.ProductId, cancellationToken);

        product.DiscountPercent = request.DiscountPercent;
        product.DiscountSold = product.Price * request.DiscountPercent / 100;
        
        if (productDiscounts.Count > 0)
        {
            foreach (var discount in productDiscounts)
            {
                discount.IsDeleted = true;
            }
        
            _productDiscountRepository.UpdateRange(productDiscounts);
        }
        
        var productDiscount = new ProductDiscount
        {
            Id = Guid.NewGuid(),
            ProductId = request.ProductId,
            Description = request.Description,
            Name = request.Name,
            StartTime = request.StartTime,
            EndTime = request.EndTime,
            DiscountPercent = request.DiscountPercent,
            CreatedBy =  Guid.NewGuid()
        };
        
        _productDiscountRepository.Add(productDiscount);
        
        await _cacheService.RemoveByPrefixAsync($"{nameof(Query.GetProductsQuery)}", cancellationToken);
        
        return Result.Success("Create Product Discount Successfully !");
    }
}