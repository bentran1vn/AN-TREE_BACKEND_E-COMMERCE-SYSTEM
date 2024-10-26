using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.UserAddress;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Antree_Ecommerce_BE.Application.UserCases.Commands.UserAddress;

public class UpdateUserAddressCommandHandler : ICommandHandler<Command.UpdateUserAddressCommand>
{
    private readonly IRepositoryBase<Domain.Entities.UserAddress, Guid> _userAddressRepository;
    private readonly IRepositoryBase<Domain.Entities.User, Guid> _userRepository;

    public UpdateUserAddressCommandHandler(IRepositoryBase<Domain.Entities.UserAddress, Guid> userAddressRepository, IRepositoryBase<User, Guid> userRepository)
    {
        _userAddressRepository = userAddressRepository;
        _userRepository = userRepository;
    }

    public async Task<Result> Handle(Command.UpdateUserAddressCommand request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.FindByIdAsync(request.UserId, cancellationToken);

        if (user is null)
        {
            return Result.Failure(new Error("404", "User not Existed !"));
        }

        var result = await _userAddressRepository.FindAll(x => !x.IsDeleted && x.UserId.Equals(request.UserId)).ToListAsync(cancellationToken);

        var notIsOrderList = result.Where(x => !x.Id.Equals(request.UserAddressId)).Select(x =>
        {
            x.IsOrder = false;
            return x;
        }).ToList();

        var isOrderAddress = result.Find(x => x.Id.Equals(request.UserAddressId));

        if (isOrderAddress is null) return Result.Failure(new Error("404", "User not Existed !"));

        isOrderAddress.IsOrder = true;
        _userAddressRepository.UpdateRange(notIsOrderList);
        _userAddressRepository.Update(isOrderAddress);
        
        return Result.Success("Set Delivery Address Successfully !");
    }
}