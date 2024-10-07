using System.Globalization;
using System.Security.Claims;
using Antree_Ecommerce_BE.Application.Abstractions;
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
    private readonly ICacheService _cacheService;
    private readonly IJwtTokenService _jwtTokenService;

    public CreateVendorCommandHandler(IRepositoryBase<Vendor, Guid> vendorRepository, IRepositoryBase<User, Guid> userRepository, IMediaService mediaService, ICacheService cacheService, IJwtTokenService jwtTokenService)
    {
        _vendorRepository = vendorRepository;
        _userRepository = userRepository;
        _mediaService = mediaService;
        _cacheService = cacheService;
        _jwtTokenService = jwtTokenService;
    }


    public async Task<Result> Handle(Command.CreateVendorCommand request, CancellationToken cancellationToken)
    {
        // var vendorTask = Task.Run(async () => 
        //     await _vendorRepository.FindSingleAsync(
        //         x => x.Name.Equals(request.VendorName), 
        //         cancellationToken
        //     )
        // );
        //
        // var userTask = Task.Run(async () => 
        //     await _userRepository.FindByIdAsync(
        //         request.UserId ?? Guid.NewGuid(), 
        //         cancellationToken, 
        //         x => x.Vendor!
        //     )
        // );
        //
        // await Task.WhenAll(vendorTask, userTask);
        //
        // var existingVendor = await vendorTask;
        // var user = await userTask;
        
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
                request.BankName, request.BankOwnerName, request.BankAccountNumber, request.UserId ?? Guid.NewGuid());
        
            _vendorRepository.Add(vendor);
            
            user.VendorId = vendor.Id;
            
            TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
            
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Role, user.Role.ToString()),
                new Claim("Role", user.Role.ToString()),
                new Claim("UserId", user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Email),
                new Claim("VendorId", vendor.Id.ToString()),
                new Claim(ClaimTypes.Expired, TimeZoneInfo.ConvertTime(DateTimeOffset.UtcNow.AddMinutes(5), vietnamTimeZone).ToString())
            };
            
            var accessToken = _jwtTokenService.GenerateAccessToken(claims);
            var refreshToken = _jwtTokenService.GenerateRefreshToken();
        
        
            var response = new Response.Authenticated()
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken,
                RefreshTokenExpiryTime = TimeZoneInfo.ConvertTime(DateTimeOffset.UtcNow.AddMinutes(15), vietnamTimeZone)
            };
            
            var slidingExpiration =  10 ;
            var absoluteExpiration = 15 ;
            var options = new DistributedCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromMinutes(slidingExpiration))
                .SetAbsoluteExpiration(TimeSpan.FromMinutes(absoluteExpiration));
        
            // await _cacheService.SetAsync($"{nameof(Query.Login)}-UserAccount:{user.Email}", response, options, cancellationToken);
            // await _cacheService.SetAsync($"{nameof(Query.Login)}-UserAccount:{user.Username}", response, options, cancellationToken);
            
            var cacheEmail =  _cacheService.SetAsync($"{nameof(Query.Login)}-UserAccount:{user.Email}", response, options, cancellationToken);
            var cacheUserName = _cacheService.SetAsync($"{nameof(Query.Login)}-UserAccount:{user.Username}", response, options, cancellationToken);
            
            await Task.WhenAll(cacheEmail, cacheUserName);
            
            return Result.Success(response);
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