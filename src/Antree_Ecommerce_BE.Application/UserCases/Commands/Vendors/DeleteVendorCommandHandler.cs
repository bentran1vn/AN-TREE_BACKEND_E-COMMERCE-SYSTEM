using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Vendors;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;

namespace Antree_Ecommerce_BE.Application.UserCases.Commands.Vendors;

public class DeleteVendorCommandHandler : ICommandHandler<Command.DeleteVendorCommand>
{
    private readonly IRepositoryBase<Vendor, Guid> _vendorRepository;
    private readonly IRepositoryBase<User, Guid> _userRepository;

    public DeleteVendorCommandHandler(IRepositoryBase<Vendor, Guid> vendorRepository, IRepositoryBase<User, Guid> userRepository)
    {
        _vendorRepository = vendorRepository;
        _userRepository = userRepository;
    }

    public async Task<Result> Handle(Command.DeleteVendorCommand request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.FindByIdAsync(
            request.UserId, cancellationToken, x => x.Vendor!);
        
        if (user is null)
        {
            throw new Exception("User Not Existed !");
        }

        if (user.VendorId is null)
        {
            throw new Exception("Not Exist Vendor !");
        }
        
        if (user.VendorId is not null && user.Vendor?.IsDeleted == true)
        {
            throw new Exception("Not Exist Vendor !");
        }
        
        _vendorRepository.Remove(user.Vendor!);

        return Result.Success("Remove Vendor Successfully !");
    }
}