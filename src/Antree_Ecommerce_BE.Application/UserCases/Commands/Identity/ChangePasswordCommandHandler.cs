using Antree_Ecommerce_BE.Application.Abstractions;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Identity;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;

namespace Antree_Ecommerce_BE.Application.UserCases.Commands.Identity;

public class ChangePasswordCommandHandler : ICommandHandler<Command.ChangePasswordCommand>
{
    private readonly IRepositoryBase<User, Guid> _userRepository;
    private readonly IPasswordHasherService _passwordHasherService;
    private readonly ICacheService _cacheService;

    public ChangePasswordCommandHandler(IRepositoryBase<User, Guid> userRepository, IPasswordHasherService passwordHasherService, ICacheService cacheService)
    {
        _userRepository = userRepository;
        _passwordHasherService = passwordHasherService;
        _cacheService = cacheService;
    }

    public async Task<Result> Handle(Command.ChangePasswordCommand request, CancellationToken cancellationToken)
    {
        var user =
            await _userRepository.FindSingleAsync(x =>
                x.Email.Equals(request.Email), cancellationToken);
        
        if (user is null)
        {
            throw new Exception("User Not Existed !");
        }
        
        var hashingPassword = _passwordHasherService.HashPassword(request.NewPassword);

        user.Password = hashingPassword;
        
        await _cacheService.RemoveAsync($"{nameof(Query.Login)}-UserAccount:{user.Email}", cancellationToken);

        return Result.Success("Change Password Successfully !");
    }
}