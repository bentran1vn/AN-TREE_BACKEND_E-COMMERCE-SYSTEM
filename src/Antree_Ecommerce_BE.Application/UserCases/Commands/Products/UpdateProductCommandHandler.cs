using Antree_Ecommerce_BE.Application.Abstractions;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Products;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;
using Antree_Ecommerce_BE.Domain.Exceptions;
using Antree_Ecommerce_BE.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Antree_Ecommerce_BE.Application.UserCases.Commands.Products;

public sealed class UpdateProductCommandHandler : ICommandHandler<Command.UpdateProductCommand>
{
    private readonly IRepositoryBase<Product, Guid> _productRepository;
    private readonly IRepositoryBase<ProductMedia, Guid> _productMediaRepository;
    private readonly IRepositoryBase<ProductDiscount, Guid> _productDiscountRepository;
    private readonly IMediaService _mediaService;
    private readonly ICacheService _cacheService;

    public UpdateProductCommandHandler(IRepositoryBase<Product, Guid> productRepository, IRepositoryBase<ProductMedia, Guid> productMediaRepository, ICacheService cacheService, IMediaService mediaService, IRepositoryBase<ProductDiscount, Guid> productDiscountRepository)
    {
        _productRepository = productRepository;
        _productMediaRepository = productMediaRepository;
        _cacheService = cacheService;
        _mediaService = mediaService;
        _productDiscountRepository = productDiscountRepository;
    }

    public async Task<Result> Handle(Command.UpdateProductCommand request, CancellationToken cancellationToken)
    {
        var product = await _productRepository.FindByIdAsync(new Guid(request.Id!), cancellationToken) 
                      ?? throw new ProductException.ProductNotFoundException(new Guid(request.Id!));

        if (!product.VendorId.Equals(request.VendorId))
        {
            return Result.Failure(new Error("401", "Can not update product of another vendor !"));
        }
       
        if (request.ProductImageCover != null)
        {
            var coverImage = await _mediaService.UploadImageAsync(request.ProductImageCover);
            product.CoverImage = coverImage;
        }
        
        if (request.ProductImages != null)
        {
            var imageMedias = await _productMediaRepository.FindAll(x => x.ProductId.Equals(new Guid(request.Id!)) && !x.IsDeleted).ToListAsync(cancellationToken);
            var imageUrlListTask = request.ProductImages.Select(x => _mediaService.UploadImageAsync(x));
            var imageUrlList = await Task.WhenAll(imageUrlListTask);
            var mediaList = imageUrlList.Select((x, index) => new ProductMedia()
            {
                Id = Guid.NewGuid(),
                ProductId = new Guid(request.Id!),
                ImageUrl = imageUrlList[index]
            }).ToList();
            
            _productMediaRepository.RemoveMultiple(imageMedias);
            _productMediaRepository.AddRange(mediaList);
        }

        if (!string.IsNullOrWhiteSpace(request.ProductCategoryId))
            product.ProductCategoryId = new Guid(request.ProductCategoryId);
        
        if (!string.IsNullOrWhiteSpace(request.Name))
            product.Name = request.Name;
        
        if (!string.IsNullOrWhiteSpace(request.Description))
            product.Description = request.Description;
        
        if (!string.IsNullOrWhiteSpace(request.Price) && decimal.TryParse(request.Price, out var decimalPrice))
            product.Price = decimalPrice;
        
        var productDiscountActive = await _productDiscountRepository
            .FindSingleAsync(x => x.IsDeleted == false && x.CreatedBy.Equals(request.VendorId) && x.ProductId.Equals(request.Id), cancellationToken);
        product.DiscountSold = product.Price - (product.Price * productDiscountActive.DiscountPercent / 100);
        
        if (!string.IsNullOrWhiteSpace(request.Sku) && int.TryParse(request.Sku, out var intSku))
            product.Sku = intSku;
        
        await _cacheService.RemoveByPrefixAsync($"{nameof(Query.GetProductsQuery)}", cancellationToken);
        
        return Result.Success("Update Product Successfully !");
    }
}