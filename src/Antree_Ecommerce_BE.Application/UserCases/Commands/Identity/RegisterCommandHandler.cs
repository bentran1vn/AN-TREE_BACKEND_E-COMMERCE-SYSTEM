using Antree_Ecommerce_BE.Application.Abstractions;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Identity;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;

namespace Antree_Ecommerce_BE.Application.UserCases.Commands.Identity;

public class RegisterCommandHandler : ICommandHandler<Command.RegisterCommand>
{
    private readonly IRepositoryBase<User, Guid> _userRepository;
    private readonly IPasswordHasherService _passwordHasherService;

    public RegisterCommandHandler(IRepositoryBase<User, Guid> userRepository, IPasswordHasherService passwordHasherService)
    {
        _userRepository = userRepository;
        _passwordHasherService = passwordHasherService;
    }

    public async Task<Result> Handle(Command.RegisterCommand request, CancellationToken cancellationToken)
    {
        var userExisted =
            await _userRepository.FindSingleAsync(x =>
                x.Email.Equals(request.Email) || x.Username.Equals(request.Username), cancellationToken);
        
        if (userExisted is not null)
        {
            throw new Exception("User Existed !");
        }

        var hashingPassword = _passwordHasherService.HashPassword(request.Password);
        
        var user = new User
        {
            Id = Guid.NewGuid(),
            Email = request.Email,
            Username = request.Username,
            Firstname = request.FirstName,
            Lastname = request.LastName,
            Role = 0,
            Phonenumber = request.Phonenumber,
            Password = hashingPassword,
            CreatedBy = Guid.Empty,
        };
        
        _userRepository.Add(user);

        return Result.Success(user);
    }
}