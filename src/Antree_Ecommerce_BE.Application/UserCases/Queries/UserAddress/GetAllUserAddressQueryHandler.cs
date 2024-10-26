using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.UserAddress;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Antree_Ecommerce_BE.Application.UserCases.Queries.UserAddress;

public class GetAllUserAddressQueryHandler : IQueryHandler<Query.GetAllUserAddressQuery, List<Response.GetAllUserAddress>>
{
    private readonly IRepositoryBase<Domain.Entities.UserAddress, Guid> _userAddressRepository;

    public GetAllUserAddressQueryHandler(IRepositoryBase<Domain.Entities.UserAddress, Guid> userAddressRepository)
    {
        _userAddressRepository = userAddressRepository;
    }

    public async Task<Result<List<Response.GetAllUserAddress>>> Handle(Query.GetAllUserAddressQuery request, CancellationToken cancellationToken)
    {
        var result = await _userAddressRepository.FindAll(x => !x.IsDeleted).ToListAsync(cancellationToken);

        return result.Select(x => new Response.GetAllUserAddress()
        {
            Id = x.Id,
            Address = x.Address,
            City = x.City,
            Province = x.Province,
            IsOrder = x.IsOrder,
            PhoneNumber = x.PhoneNumber,
            CreatedOnUtc = x.CreatedOnUtc
        }).ToList();
    }
}