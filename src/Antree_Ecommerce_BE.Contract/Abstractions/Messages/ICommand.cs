using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using MediatR;

namespace Antree_Ecommerce_BE.Contract.Abstractions.Messages;

public interface ICommand : IRequest<Result>
{
}

public interface ICommand<TResponse> : IRequest<Result<TResponse>>
{
}
