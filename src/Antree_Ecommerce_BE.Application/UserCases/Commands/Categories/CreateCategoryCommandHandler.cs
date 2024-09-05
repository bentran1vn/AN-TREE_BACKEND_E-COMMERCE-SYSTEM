using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Categories;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;

namespace Antree_Ecommerce_BE.Application.UserCases.Commands.Categories;

public class CreateCategoryCommandHandler : ICommandHandler<Command.CreateCategoryCommand>
{
    private readonly IRepositoryBase<ProductCategory, Guid> _productCategoryRepository;

    public CreateCategoryCommandHandler(IRepositoryBase<ProductCategory, Guid> productCategoryRepository)
    {
        _productCategoryRepository = productCategoryRepository;
    }

    public async Task<Result> Handle(Command.CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        var productCategory = ProductCategory.CreateProductCategory(Guid.NewGuid(), request.Name, request.Description,
            Guid.NewGuid(), Guid.Empty);
        
        _productCategoryRepository.Add(productCategory);
        
        return Result.Success();
    }
}