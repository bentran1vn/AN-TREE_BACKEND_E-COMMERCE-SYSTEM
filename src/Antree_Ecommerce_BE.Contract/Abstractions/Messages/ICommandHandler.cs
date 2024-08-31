using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using MediatR;

namespace Antree_Ecommerce_BE.Contract.Abstractions.Messages;

public interface ICommandHandler<TCommand> : IRequestHandler<TCommand, Result>
    where TCommand : ICommand
{
}

public interface ICommandHandler<TCommand, TResponse> : IRequestHandler<TCommand, Result<TResponse>>
    where TCommand : ICommand<TResponse>
{
}
