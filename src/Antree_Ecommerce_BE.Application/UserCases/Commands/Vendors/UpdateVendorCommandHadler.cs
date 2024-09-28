using Antree_Ecommerce_BE.Application.Abstractions;
using Antree_Ecommerce_BE.Application.DependencyInjection.Extensions;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Vendors;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;
using Microsoft.Extensions.Caching.Distributed;

namespace Antree_Ecommerce_BE.Application.UserCases.Commands.Vendors;

public class UpdateVendorCommandHadler : ICommandHandler<Command.UpdateVendorCommand>
{
    private readonly IRepositoryBase<Vendor, Guid> _vendorRepository;
    private readonly ICacheService _cacheService;
    private readonly IMediaService _mediaService;
    private readonly IMailService _mailService;

    public UpdateVendorCommandHadler(IRepositoryBase<Vendor, Guid> vendorRepository, IMediaService mediaService, ICacheService cacheService, IMailService mailService)
    {
        _vendorRepository = vendorRepository;
        _mediaService = mediaService;
        _cacheService = cacheService;
        _mailService = mailService;
    }

    public async Task<Result> Handle(Command.UpdateVendorCommand request, CancellationToken cancellationToken)
    {
        if (!(string.IsNullOrWhiteSpace(request.BankAccountNumber)
             || string.IsNullOrWhiteSpace(request.BankName)
             || string.IsNullOrWhiteSpace(request.BankOwnerName)))
        {
            throw new Exception("Missing Field of BankAccountNumber or BankName or BankOwnerName!");
        }
        
        var vendor = await _vendorRepository.FindSingleAsync(
            x => x.Id.Equals(request.VendorId), 
            cancellationToken
        );

        if (vendor.IsDeleted)
        {
            throw new Exception("Your Vendor is not existed !");
        }
        
        if ((!string.IsNullOrWhiteSpace(request.BankAccountNumber)
            && !string.IsNullOrWhiteSpace(request.BankName)
            && !string.IsNullOrWhiteSpace(request.BankOwnerName))
            || !string.IsNullOrWhiteSpace(request.PhoneNumber)
            || !string.IsNullOrWhiteSpace(request.VendorEmail))
        {
            Random random = new Random();
            var randomNumber = random.Next(0, 100000).ToString("D5");
        
            var slidingExpiration = 120;
            var absoluteExpiration = 120;
            var options = new DistributedCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromSeconds(slidingExpiration))
                .SetAbsoluteExpiration(TimeSpan.FromSeconds(absoluteExpiration));
            
            await _mailService.SendMail(EmailExtensions.ConfirmUpdateVendorBody(randomNumber, $"{vendor.Name}", vendor.Email, request.BankAccountNumber, request.BankName, request.BankOwnerName, request.PhoneNumber, request.VendorEmail));
            
            await _cacheService.SetAsync($"{nameof(Command.UpdateVendorCommand)}-VendorEmail:{vendor.Email}", randomNumber, options, cancellationToken);
        }


        if (request.AvatarImage != null && request.CoverImage != null)
        {
            var imageUploadTasks = await Task.WhenAll(
                _mediaService.UploadImageAsync(request.AvatarImage),
                _mediaService.UploadImageAsync(request.CoverImage)
            );

            var avatarUrl = imageUploadTasks[0];
            var coverUrl = imageUploadTasks[1];
            
            vendor.AvatarImage = avatarUrl;
            vendor.CoverImage = coverUrl;
        }
        else
        {
            if (request.AvatarImage != null)
            {
                var avatarUrl = await _mediaService.UploadImageAsync(request.AvatarImage);
                vendor.AvatarImage = avatarUrl;
            }
            if (request.CoverImage != null)
            {
                var coverUrl = await _mediaService.UploadImageAsync(request.CoverImage);
                vendor.CoverImage = coverUrl;
            }
        }
        
        if (!string.IsNullOrWhiteSpace(request.VendorName))
            vendor.Name = request.VendorName;

        if (!string.IsNullOrWhiteSpace(request.Address))
            vendor.Address = request.Address;

        if (!string.IsNullOrWhiteSpace(request.City))
            vendor.City = request.City;

        if (!string.IsNullOrWhiteSpace(request.Province))
            vendor.Province = request.Province;

        return Result.Success("Update Vendor Successfully !");
    }
}