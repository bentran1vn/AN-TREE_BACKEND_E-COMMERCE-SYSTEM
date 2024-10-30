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
    private readonly IRepositoryBase<ProductMedia, Guid> _productMediaRepository;
    private readonly ICacheService _cacheService;
    private readonly IMediaService _mediaService;

    public CreateProductCommandHandler(IRepositoryBase<Product, Guid> productRepository, ICacheService cacheService, IMediaService mediaService, IRepositoryBase<ProductMedia, Guid> productMediaRepository)
    {
        _productRepository = productRepository;
        _cacheService = cacheService;
        _mediaService = mediaService;
        _productMediaRepository = productMediaRepository;
    }

    public async Task<Result> Handle(Command.CreateProductCommand request, CancellationToken cancellationToken)
    {
        var coverImage = await _mediaService.UploadImageAsync(request.ProductImageCover);
        
        // IEnumerable<Task<string>> imageUrlListTask = request.ProductImages?.Any() != true ? []
        //     : request.ProductImages.Select(image => _mediaService.UploadImageAsync(image));
        
        var imageUrlListTask = new List<Task<string>>();
        
        foreach (var requestProductImage in request.ProductImages)
        {
            imageUrlListTask.Add(_mediaService.UploadImageAsync(requestProductImage));
        }

        var imageUrlList = await Task.WhenAll(imageUrlListTask);
        
        var product = Product.CreateProduct(
            Guid.NewGuid(), 
            new Guid(request.ProductCategoryId), request.VendorId ?? new Guid(), request.Name,
            request.Price, request.Description, request.Sku, request.Sold,
            coverImage, Guid.NewGuid(), Guid.Empty
        );
        _productRepository.Add(product);
        
        List<ProductMedia> productMedias = new List<ProductMedia>();
        foreach (var url in imageUrlList)
        {
            productMedias.Add(new ProductMedia()
            {
                Id = new Guid(),
                ImageUrl = url,
                ProductId = product.Id
            });
        }
        _productMediaRepository.AddRange(productMedias);

        await _cacheService.RemoveByPrefixAsync($"{nameof(Query.GetProductsQuery)}", cancellationToken);

        return Result.Success("Create Product Successfully !");
    }
}