using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using MediatR;

namespace Antree_Ecommerce_BE.Contract.Abstractions.Messages;

public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>>
    where TQuery : IQuery<TResponse>
{
}