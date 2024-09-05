namespace Antree_Ecommerce_BE.Contract.Services.Categories;

public class Response
{
    public record CategoryResponse(Guid Id, string Name, string Description);
}