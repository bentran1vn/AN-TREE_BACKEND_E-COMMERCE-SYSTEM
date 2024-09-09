using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Enumerations;

namespace Antree_Ecommerce_BE.Contract.Services.Feedbacks;

public class Query
{
    public record GetFeedbacksQuery(Guid? ProductId, string? SortColumn, SortOrder? SortOrder, int PageIndex, int PageSize) : IQuery<PagedResult<Response.FeedbackResonse>>;
}