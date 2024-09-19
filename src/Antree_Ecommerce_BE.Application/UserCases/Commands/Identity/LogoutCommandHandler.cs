using Antree_Ecommerce_BE.Application.Abstractions;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Identity;

namespace Antree_Ecommerce_BE.Application.UserCases.Commands.Identity;

public class LogoutCommandHandler : ICommandHandler<Command.LogoutCommand>
{
    private readonly ICacheService _cacheService;

    public LogoutCommandHandler(ICacheService cacheService)
    {
        _cacheService = cacheService;
    }

    public async Task<Result> Handle(Command.LogoutCommand request, CancellationToken cancellationToken)
    {
        await _cacheService.RemoveAsync($"{nameof(Query.Login)}-UserAccount:{request.UserAccount}", cancellationToken);
        return Result.Success("Logout Successfully");
    }
}