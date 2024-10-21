using Antree_Ecommerce_BE.Application.Abstractions;
using Antree_Ecommerce_BE.Application.DependencyInjection.Extensions;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Vendors;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;

namespace Antree_Ecommerce_BE.Application.UserCases.Commands.Vendors;

public class VerifyVendorCommandHandler : ICommandHandler<Command.VerifyVendorCommand>
{
    private readonly IRepositoryBase<Vendor, Guid> _vendorRepository;
    private readonly IMailService _mailService;

    public VerifyVendorCommandHandler(IRepositoryBase<Vendor, Guid> vendorRepository, IMailService mailService)
    {
        _vendorRepository = vendorRepository;
        _mailService = mailService;
    }

    public async Task<Result> Handle(Command.VerifyVendorCommand request, CancellationToken cancellationToken)
    {
        var vendor = await _vendorRepository.FindByIdAsync(request.VendorId, cancellationToken);
        if (vendor is null)
        {
            return Result.Failure(new Error("400", "Can not find Vendor !"));
        }
        if (request.IsAccepted)
        {
            vendor.Status = 0;
            await _mailService.SendMail(EmailExtensions.RespondToVendorRequest(vendor.Name, vendor.Email, true));
            return Result.Success("Accept the vendor successfully !");
        }
        await _mailService.SendMail(EmailExtensions.RespondToVendorRequest(vendor.Name, vendor.Email, false));
        return Result.Success("Reject the vendor successfully !");
    }
}