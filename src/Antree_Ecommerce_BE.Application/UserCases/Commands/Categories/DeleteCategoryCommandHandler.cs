using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Categories;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;

namespace Antree_Ecommerce_BE.Application.UserCases.Commands.Categories;

public class DeleteCategoryCommandHandler : ICommandHandler<Command.DeleteCategoryCommand>
{
    private readonly IRepositoryBase<ProductCategory, Guid> _productCategoryRepository;

    public DeleteCategoryCommandHandler(IRepositoryBase<ProductCategory, Guid> productCategoryRepository)
    {
        _productCategoryRepository = productCategoryRepository;
    }

    public async Task<Result> Handle(Command.DeleteCategoryCommand request, CancellationToken cancellationToken)
    {
        var productCategory =
            await _productCategoryRepository.FindByIdAsync(request.CategoryId, cancellationToken) ?? throw new Exception("hahah");
        _productCategoryRepository.Remove(productCategory);
        return Result.Success();
    }
}