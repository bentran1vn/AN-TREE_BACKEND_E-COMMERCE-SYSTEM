using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Categories;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;

namespace Antree_Ecommerce_BE.Application.UserCases.Commands.Categories;

public class UpdateCategoryCommandHandler : ICommandHandler<Command.UpdateCategoryCommand>
{
    private readonly IRepositoryBase<ProductCategory, Guid> _productCategoryRepository;

    public UpdateCategoryCommandHandler(IRepositoryBase<ProductCategory, Guid> productCategoryRepository)
    {
        _productCategoryRepository = productCategoryRepository;
    }

    public async Task<Result> Handle(Command.UpdateCategoryCommand request, CancellationToken cancellationToken)
    {
        var productCategory =
            await _productCategoryRepository.FindByIdAsync(request.Id, cancellationToken) ?? throw new Exception("hahah");
        productCategory.UpdateProductCategory(request.Name, request.Description, Guid.NewGuid(), request.IsDeleted);
        return Result.Success();
    }
}