using Antree_Ecommerce_BE.Contract.Abstractions.Messages;

namespace Antree_Ecommerce_BE.Contract.Services.Categories;

public static class Command
{
    public record CreateCategoryCommand(string Name, string Description) : ICommand;
    public record UpdateCategoryCommand(Guid CategoryId, string? Name, string? Description, bool? IsDeleted): ICommand;
    public record DeleteCategoryCommand(Guid CategoryId): ICommand;
}