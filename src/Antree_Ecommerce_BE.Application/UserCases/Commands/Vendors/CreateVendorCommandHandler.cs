using System.Globalization;
using System.Security.Claims;
using Antree_Ecommerce_BE.Application.Abstractions;
using Antree_Ecommerce_BE.Application.DependencyInjection.Extensions;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Vendors;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;
using Microsoft.Extensions.Caching.Distributed;
using Query = Antree_Ecommerce_BE.Contract.Services.Identity.Query;
using Response = Antree_Ecommerce_BE.Contract.Services.Identity.Response;

namespace Antree_Ecommerce_BE.Application.UserCases.Commands.Vendors;

public class CreateVendorCommandHandler : ICommandHandler<Command.CreateVendorCommand>
{
    private readonly IRepositoryBase<Vendor, Guid> _vendorRepository;
    private readonly IRepositoryBase<User, Guid> _userRepository;
    private readonly IMediaService _mediaService;
    private readonly IMailService _mailService;


    public CreateVendorCommandHandler(IRepositoryBase<Vendor, Guid> vendorRepository, IRepositoryBase<User, Guid> userRepository, IMediaService mediaService, IMailService mailService)
    {
        _vendorRepository = vendorRepository;
        _userRepository = userRepository;
        _mediaService = mediaService;
        _mailService = mailService;
    }


    public async Task<Result> Handle(Command.CreateVendorCommand request, CancellationToken cancellationToken)
    {
        var existingVendor = await _vendorRepository.FindSingleAsync(
            x => x.Name.Equals(request.VendorName), 
            cancellationToken
        );
        
        if (existingVendor is not null)
        {
            throw new Exception($"Exist Vendor has name: {request.VendorName}");
        }
        
        var user = await _userRepository.FindByIdAsync(
            request.UserId ?? Guid.NewGuid(), 
            cancellationToken, 
            x => x.Vendor!
        );
        
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
            var vendor = new Vendor(Guid.NewGuid(), request.VendorEmail, request.VendorName, request.Address,
                request.City, request.Province, request.PhoneNumber, avatarUrl, coverUrl,
                request.BankName, request.BankOwnerName, request.BankAccountNumber, request.UserId ?? Guid.NewGuid(), 1);
        
            _vendorRepository.Add(vendor);
            
            user.VendorId = vendor.Id;

            await _mailService.SendMail(EmailExtensions.RequestCreateVendor(vendor.Name, vendor.Email));
            
            return Result.Success("Send Request For Create Vendor Successfully !");
        }
        else if(user.VendorId != null && user.Vendor!.Status == 1)
        {
            return Result.Success("Please wait for the verify process !"); 
        }
        else if(user.VendorId != null)
        {
            user.Vendor!.UpdateVendor(request.VendorEmail, request.VendorName, request.Address,
                request.City, request.Province, request.PhoneNumber, avatarUrl, coverUrl,
                request.BankName, request.BankOwnerName, request.BankAccountNumber, request.UserId ?? Guid.NewGuid()
                , false, 1);
            
            await _mailService.SendMail(EmailExtensions.RequestCreateVendor(user.Vendor.Name, user.Vendor.Email));
            
            return Result.Success("Send Request For Create Vendor Successfully !");
        }
        else
        {
            return Result.Success("Create Vendors Successfully !");
        }
    }
}