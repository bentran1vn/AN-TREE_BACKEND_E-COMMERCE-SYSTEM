using Antree_Ecommerce_BE.Application.Abstractions;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.ProductDiscounts;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;
using Query = Antree_Ecommerce_BE.Contract.Services.Products.Query;

namespace Antree_Ecommerce_BE.Application.UserCases.Commands.ProductDiscounts;

public class UpdateProductDiscountCommandHandler : ICommandHandler<Command.UpdateProductDiscountCommand>
{
    private readonly IRepositoryBase<ProductDiscount, Guid> _productDiscountRepository;
    private readonly ICacheService _cacheService;

    public UpdateProductDiscountCommandHandler(IRepositoryBase<ProductDiscount, Guid> productDiscountRepository, ICacheService cacheService)
    {
        _productDiscountRepository = productDiscountRepository;
        _cacheService = cacheService;
    }

    public async Task<Result> Handle(Command.UpdateProductDiscountCommand request, CancellationToken cancellationToken)
    {
        var productDiscounts = await _productDiscountRepository.FindByIdAsync(request.ProductDiscountId, cancellationToken, x => x.Product);
        

        if (productDiscounts.CreatedBy != request.VendorId)
        {
            return Result.Failure(new Error("403", "Forbidden, Can not update this ProductDiscount !"));
        }
        
        
        if (!productDiscounts.IsDeleted && request.IsDeleted)
        {
            productDiscounts.IsDeleted = true;
        }
        else
        {
            var productDiscountActive = await _productDiscountRepository
                .FindSingleAsync(x => x.IsDeleted == false && x.CreatedBy.Equals(request.VendorId), cancellationToken);
            
            if (!request.IsDeleted)
            {
                if (productDiscountActive is not null)
                {
                    productDiscountActive.IsDeleted = true;
                }
                productDiscounts.IsDeleted = false;
                productDiscounts.Product.DiscountPercent = request.DiscountPercent;
                productDiscounts.Product.DiscountSold = request.DiscountPercent * productDiscounts.Product.Price;
            }
        }
        
        productDiscounts.DiscountPercent = request.DiscountPercent;
        productDiscounts.Description = request.Description;
        productDiscounts.Name = request.Name;
        productDiscounts.StartTime = request.StartTime;
        productDiscounts.EndTime = request.EndTime;
        productDiscounts.UpdatedBy = request.VendorId;
        
        await _cacheService.RemoveByPrefixAsync($"{nameof(Query.GetProductsQuery)}", cancellationToken);
        
        return Result.Success("Update Product Discount Successfully !");
    }
}