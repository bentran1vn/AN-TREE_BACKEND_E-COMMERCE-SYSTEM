using Antree_Ecommerce_BE.Contract.Abstractions.Messages;

namespace Antree_Ecommerce_BE.Contract.Services.Categories;

public class Command
{
    public record CreateCategoryCommand(string Name, string Description) : ICommand;

    public record UpdateProductCommand(Guid Id, string Name, string Description): ICommand;
}