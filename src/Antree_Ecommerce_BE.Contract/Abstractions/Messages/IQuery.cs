using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using MediatR;

namespace Antree_Ecommerce_BE.Contract.Abstractions.Messages;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}