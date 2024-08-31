namespace Antree_Ecommerce_BE.Contract.Services.Products;

public static class Response
{
    public record ProductResponse(Guid Id, string Name, decimal Price, string Description);
}
