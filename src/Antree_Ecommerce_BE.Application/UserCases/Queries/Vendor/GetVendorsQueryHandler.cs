using System.Linq.Expressions;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Enumerations;
using Antree_Ecommerce_BE.Contract.Services.Vendors;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using AutoMapper;

namespace Antree_Ecommerce_BE.Application.UserCases.Queries.Vendor;

public class GetVendorsQueryHandler : IQueryHandler<Query.GetVendorsQuery, PagedResult<Response.VendorResponse>>
{
    private readonly IRepositoryBase<Domain.Entities.Vendor, Guid> _vendorRepository;
    private readonly IMapper _mapper;

    public GetVendorsQueryHandler(IRepositoryBase<Domain.Entities.Vendor, Guid> vendorRepository, IMapper mapper)
    {
        _vendorRepository = vendorRepository;
        _mapper = mapper;
    }

    public async Task<Result<PagedResult<Response.VendorResponse>>> Handle(Query.GetVendorsQuery request, CancellationToken cancellationToken)
    {
        var vendorsQuery = string.IsNullOrWhiteSpace(request.SearchTerm)
            ? _vendorRepository.FindAll(null)
            : _vendorRepository.FindAll(
                x => x.Name.ToLower().Contains(request.SearchTerm.ToLower()));

        vendorsQuery = !request.IsPending
            ? vendorsQuery
            : vendorsQuery.Where(x => x.Status == 1);
        
        vendorsQuery = request.SortOrder == SortOrder.Descending
            ? vendorsQuery.OrderByDescending(GetSortProperty(request))
            : vendorsQuery.OrderBy(GetSortProperty(request));

        var products = await PagedResult<Domain.Entities.Vendor>.CreateAsync(vendorsQuery,
            request.PageIndex,
            request.PageSize);
        
        var result = _mapper.Map<PagedResult<Response.VendorResponse>>(products);
        
        return Result.Success(result);
    }
    
    private static Expression<Func<Domain.Entities.Vendor, object>> GetSortProperty(Query.GetVendorsQuery request)
        => request.SortColumn?.ToLower() switch
        {
            "name" => vendor => vendor.Name,
            _ => vendor => vendor.Id
            //_ => product => product.CreatedDate // Default Sort Descending on CreatedDate column
        };
}