using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;

namespace Antree_Ecommerce_BE.Contract.Services.Categories;

public class Query
{
    public record GetCategoriesQuery() : IQuery<ListResult<Response.CategoryResponse>>;
}