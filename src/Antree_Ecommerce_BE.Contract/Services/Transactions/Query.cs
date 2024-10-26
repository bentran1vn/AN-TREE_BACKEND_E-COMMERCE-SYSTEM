using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;

namespace Antree_Ecommerce_BE.Contract.Services.Transactions;

public class Query
{
    public record GetAllTransactionsQuery(Guid? UserId, string? SearchTerm, int PageIndex, int PageSize) : IQuery<PagedResult<Response.GetAllTransaction>>;
}