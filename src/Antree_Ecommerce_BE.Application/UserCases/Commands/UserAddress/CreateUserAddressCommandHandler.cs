using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.UserAddress;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Antree_Ecommerce_BE.Application.UserCases.Commands.UserAddress;

public class CreateUserAddressCommandHandler : ICommandHandler<Command.CreateUserAddressCommand>
{
    private readonly IRepositoryBase<Domain.Entities.UserAddress, Guid> _userAddressRepository;
    private readonly IRepositoryBase<Domain.Entities.User, Guid> _userRepository;

    public CreateUserAddressCommandHandler(IRepositoryBase<Domain.Entities.UserAddress, Guid> userAddressRepository, IRepositoryBase<User, Guid> userRepository)
    {
        _userAddressRepository = userAddressRepository;
        _userRepository = userRepository;
    }

    public async Task<Result> Handle(Command.CreateUserAddressCommand request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.FindByIdAsync(request.UserId, cancellationToken);

        if (user is null)
        {
            return Result.Failure(new Error("404", "User not Existed !"));
        }

        var exitAddress = await _userAddressRepository.FindAll(x => x.UserId.Equals(request.UserId) && !x.IsDeleted).ToListAsync(cancellationToken);
        
        var userAddress = new Domain.Entities.UserAddress()
        {
            Id = Guid.NewGuid(),
            Address = request.Address,
            City = request.City,
            Province = request.Province,
            IsOrder = false,
            PhoneNumber = request.PhoneNumber,
            UserId = request.UserId
        };

        if (exitAddress is null || exitAddress.Count == 0) userAddress.IsOrder = true;
        
        _userAddressRepository.Add(userAddress);

        return Result.Success("Create Address Successfully !");
    }
}