using Antree_Ecommerce_BE.Application.Abstractions;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Vendors;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;

namespace Antree_Ecommerce_BE.Application.UserCases.Commands.Vendors;

public class ConfirmUpdateVendorCommandHandler : ICommandHandler<Command.ConfirmUpdateVendorCommand>
{
    private readonly IRepositoryBase<Vendor, Guid> _vendorRepository;
    private readonly ICacheService _cacheService;

    public ConfirmUpdateVendorCommandHandler(IRepositoryBase<Vendor, Guid> vendorRepository, ICacheService cacheService)
    {
        _vendorRepository = vendorRepository;
        _cacheService = cacheService;
    }

    public async Task<Result> Handle(Command.ConfirmUpdateVendorCommand request, CancellationToken cancellationToken)
    {
        if (string.IsNullOrWhiteSpace(request.VerifyCode))
        {
            return Result.Failure(new Error("400", "Verify Code is required."));
        }
        
        var vendor = await _vendorRepository.FindSingleAsync(
            x => x.CreatedBy.Equals(request.UserId), 
            cancellationToken
        );

        if (vendor == null || vendor.IsDeleted)
        {
            return Result.Failure(new Error("404", "Vendor not found or has been deleted."));
        }
        
        var code = await _cacheService.GetAsync<string>(
            $"{nameof(Command.UpdateVendorCommand)}-VendorEmail:{vendor.Email}", cancellationToken);
        
        if (code == null || !code.Equals(request.VerifyCode))
        {
            return Result.Failure(new Error("500", "Verify Code is Wrong !"));
        }
        
        if (!string.IsNullOrWhiteSpace(request.BankAccountNumber) &&
            !string.IsNullOrWhiteSpace(request.BankName) &&
            !string.IsNullOrWhiteSpace(request.BankOwnerName))
        {
            vendor.BankName = request.BankName;
            vendor.BankAccountNumber = request.BankAccountNumber;
            vendor.BankOwnerName = request.BankOwnerName;
        }
        
        else if (request.BankAccountNumber != null || request.BankName != null || request.BankOwnerName != null)
        {
            return Result.Failure(new Error("400", "All bank information fields must be provided together."));
        }
        
        if (!string.IsNullOrWhiteSpace(request.VendorEmail))
            vendor.Email = request.VendorEmail;
        
        if (!string.IsNullOrWhiteSpace(request.PhoneNumber))
            vendor.Phonenumber = request.PhoneNumber;

        return Result.Success("Update Vendor Successfully !");
    }
}