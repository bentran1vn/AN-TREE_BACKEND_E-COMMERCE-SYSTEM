using Antree_Ecommerce_BE.Contract.Abstractions.Messages;

namespace Antree_Ecommerce_BE.Contract.Services.Categories;

public class Query
{
    public record GetCategoriesQuery() : IQuery<List<Response.CategoryResponse>>;
}