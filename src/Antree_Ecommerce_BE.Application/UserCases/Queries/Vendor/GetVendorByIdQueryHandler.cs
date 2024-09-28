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
        var vendor = await _vendorRepository.FindSingleAsync(
            x => x.Id.Equals(request.VendorId),
            cancellationToken
        );

        if (vendor.IsDeleted)
        {
            throw new Exception("Vendor is not existed !");
        }
        
        var result = _mapper.Map<Response.VendorResponse>(vendor);

        return Result.Success(result);
    }
}