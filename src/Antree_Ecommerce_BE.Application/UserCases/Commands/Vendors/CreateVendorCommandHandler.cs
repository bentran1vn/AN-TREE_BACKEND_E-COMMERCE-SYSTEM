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
        var vendorTask = _vendorRepository.FindSingleAsync(
            x => x.Name.Equals(request.VendorName, StringComparison.OrdinalIgnoreCase), 
            cancellationToken
        );
        var userTask = _userRepository.FindByIdAsync(
            request.UserId ?? Guid.NewGuid(), 
            cancellationToken, 
            x => x.Vendor!
        );

        await Task.WhenAll(vendorTask, userTask);
        
        var existingVendor = await vendorTask;
        var user = await userTask;

        if (existingVendor is not null)
        {
            throw new Exception($"Exist Vendor has name: {request.VendorName}");
        }
        
        if (user is null)
        {
            throw new Exception("User Not Existed !");
        }
        
        if (user.Vendor?.IsDeleted == false)
        {
            throw new Exception("Please Remove Your Vendor First !");
        }
        
        var imageUploadTasks = await Task.WhenAll(
            _mediaService.UploadImageAsync(request.AvatarImage),
            _mediaService.UploadImageAsync(request.CoverImage)
        );

        var avatarUrl = imageUploadTasks[0];
        var coverUrl = imageUploadTasks[1];

        if (user.VendorId == null)
        {
            var vendor = new Vendor(request.Id ?? Guid.NewGuid(), request.VendorEmail, request.VendorName, request.Address,
                request.City, request.Province, request.PhoneNumber, avatarUrl, coverUrl,
                request.BankName, request.BankOwnerName, request.BankAccountNumber, request.UserId ?? Guid.NewGuid());
        
            _vendorRepository.Add(vendor);
            
            user.VendorId = vendor.Id;
        }
        else if(user.VendorId != null)
        {
            user.Vendor!.UpdateVendor(request.VendorEmail, request.VendorName, request.Address,
                request.City, request.Province, request.PhoneNumber, avatarUrl, coverUrl,
                request.BankName, request.BankOwnerName, request.BankAccountNumber, request.UserId ?? Guid.NewGuid(), false);

        }
        
        return Result.Success("Create Vendors Successfully !");
    }
}