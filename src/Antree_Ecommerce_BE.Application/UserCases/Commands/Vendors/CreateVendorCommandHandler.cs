using Antree_Ecommerce_BE.Application.Abstractions;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Vendors;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;

namespace Antree_Ecommerce_BE.Application.UserCases.Commands.Vendors;

public class CreateVendorCommandHandler : ICommandHandler<Command.CreateVendorCommand>
{
    private readonly IRepositoryBase<Vendor, Guid> _vendorRepository;
    private readonly IRepositoryBase<User, Guid> _userRepository;
    private readonly IMediaService _mediaService;

    public CreateVendorCommandHandler(IRepositoryBase<Vendor, Guid> vendorRepository, IRepositoryBase<User, Guid> userRepository, IMediaService mediaService)
    {
        _vendorRepository = vendorRepository;
        _userRepository = userRepository;
        _mediaService = mediaService;
    }


    public async Task<Result> Handle(Command.CreateVendorCommand request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.FindByIdAsync(
            request.UserId ?? Guid.NewGuid(), cancellationToken, x => x.Vendor!);
        
        if (user is null)
        {
            throw new Exception("User Not Existed !");
        }
        
        if (user.Vendor?.IsDeleted == false)
        {
            throw new Exception("Please Remove Your Vendor First !");
        }
        
        var result = await Task.WhenAll(
            _mediaService.UploadImageAsync(request.AvatarImage),
            _mediaService.UploadImageAsync(request.CoverImage)
        );

        if (user.VendorId == null)
        {
            var vendor = new Vendor(request.Id ?? Guid.NewGuid(), request.VendorEmail, request.VendorName, request.Address,
                request.City, request.Province, request.PhoneNumber, result[0], result[1],
                request.BankName, request.BankOwnerName, request.BankAccountNumber, request.UserId ?? Guid.NewGuid());
        
            _vendorRepository.Add(vendor);
            
            user.VendorId = vendor.Id;
        }
        else if(user.VendorId != null)
        {
            user.Vendor!.UpdateVendor(request.VendorEmail, request.VendorName, request.Address,
                request.City, request.Province, request.PhoneNumber, result[0], result[1],
                request.BankName, request.BankOwnerName, request.BankAccountNumber, request.UserId ?? Guid.NewGuid(), false);

        }
        
        return Result.Success("Create Vendors Successfully !");
    }
}