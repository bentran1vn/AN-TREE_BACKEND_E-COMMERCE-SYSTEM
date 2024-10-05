using Antree_Ecommerce_BE.Application.Abstractions;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Products;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;
using Antree_Ecommerce_BE.Domain.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace Antree_Ecommerce_BE.Application.UserCases.Commands.Products;

public sealed class UpdateProductCommandHandler : ICommandHandler<Command.UpdateProductCommand>
{
    private readonly IRepositoryBase<Product, Guid> _productRepository;
    private readonly IRepositoryBase<ProductMedia, Guid> _productMediaRepository;
    private readonly IMediaService _mediaService;

    public UpdateProductCommandHandler(IRepositoryBase<Product, Guid> productRepository, IRepositoryBase<ProductMedia, Guid> productMediaRepository, ICacheService cacheService, IMediaService mediaService)
    {
        _productRepository = productRepository;
        _productMediaRepository = productMediaRepository;
        _mediaService = mediaService;
    }

    public async Task<Result> Handle(Command.UpdateProductCommand request, CancellationToken cancellationToken)
    {
        var product = await _productRepository.FindByIdAsync(request.Id, cancellationToken) 
                      ?? throw new ProductException.ProductNotFoundException(request.Id);
        
        var productMedia = await _productMediaRepository.FindAll(x => x.ProductId.Equals(request.Id)).ToListAsync(cancellationToken);
       
        // if (request.ProductImageCover != null)
        // {
        //     var coverImage = await _mediaService.UploadImageAsync(request.ProductImageCover);
        //     product.CoverImage = coverImage;
        // }
        //
        // if (request.ProductImages != null)
        // {
        //     var imageUrlListTask = request.ProductImages.Select(x => _mediaService.UploadImageAsync(x));
        //     var imageUrlList = await Task.WhenAll(imageUrlListTask);
        //     productMedia = productMedia.Select((x, index) => new ProductMedia()
        //     {
        //         Id = x.Id,
        //         ProductId = request.Id,
        //         ImageUrl = imageUrlList[index],
        //         IsDeleted = x.IsDeleted
        //     }).ToList();
        //     _productMediaRepository.UpdateRange(productMedia);
        // }

        if (request.ProductCategoryId != null)
            product.ProductCategoryId = (Guid)request.ProductCategoryId;
        
        if (!string.IsNullOrWhiteSpace(request.Name))
            product.Name = request.Name;
        
        if (!string.IsNullOrWhiteSpace(request.Description))
            product.Description = request.Description;
        
        if (request.Price != null)
            product.Price = (decimal)request.Price;
        
        if (request.Sku != null)
            product.Sku = (int)request.Sku;
        
        return Result.Success("Update Product Successfully !");
    }
}