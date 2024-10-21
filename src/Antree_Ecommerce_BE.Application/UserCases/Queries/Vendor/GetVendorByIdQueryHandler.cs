using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Vendors;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using AutoMapper;

namespace Antree_Ecommerce_BE.Application.UserCases.Queries.Vendor;

public class GetVendorByIdQueryHandler : IQueryHandler<Query.GetVendorByIdQuery, Response.VendorResponse>
{
    private readonly IRepositoryBase<Domain.Entities.Vendor, Guid> _vendorRepository;
    private readonly IMapper _mapper;

    public GetVendorByIdQueryHandler(IRepositoryBase<Domain.Entities.Vendor, Guid> vendorRepository, IMapper mapper)
    {
        _vendorRepository = vendorRepository;
        _mapper = mapper;
    }

    public async Task<Result<Response.VendorResponse>> Handle(Query.GetVendorByIdQuery request, CancellationToken cancellationToken)
    {
        if (request.VendorId is null && request.UserId is null)
        {
            return Result.Failure<Response.VendorResponse>(new Error("401", "Unauthorize !"));
        }

        if (request.UserId is not null)
        {
            var vendorUser = await _vendorRepository.FindSingleAsync(
                x => x.CreatedBy.Equals(new Guid(request.UserId!)),
                cancellationToken
            );
            
            if (request.VendorId is null && vendorUser is not null && vendorUser.Status == 1)
            {
                return Result.Failure<Response.VendorResponse>(new Error("500", "Please Wait for Response"));
            }
        
            if (request.VendorId is null && vendorUser is null)
            {
                return Result.Failure<Response.VendorResponse>(new Error("400", "Vendor is not existed !"));
            }
        }
        
        var vendor = await _vendorRepository.FindSingleAsync(
            x => x.Id.Equals(new Guid(request.VendorId!)),
            cancellationToken
        );
        
        if (vendor is null)
        {
            return Result.Failure<Response.VendorResponse>(new Error("400", "Vendor is not existed !"));
        }
        
        if (vendor.Status == 1)
        {
            var result1 = _mapper.Map<Response.VendorResponse>(vendor);

            return Result.Success(result1);
        }

        if (vendor?.IsDeleted == true)
        {
            return Result.Failure<Response.VendorResponse>(new Error("400", "Vendor is not existed !"));
        }
        
        var result = _mapper.Map<Response.VendorResponse>(vendor);

        return Result.Success(result);
    }
}