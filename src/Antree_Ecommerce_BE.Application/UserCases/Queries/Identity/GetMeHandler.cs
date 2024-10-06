using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Identity;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;
using AutoMapper;

namespace Antree_Ecommerce_BE.Application.UserCases.Queries.Identity;

public class GetMeHandler : IQueryHandler<Query.GetMe, Response.GetMe>
{
    private readonly IRepositoryBase<User, Guid> _userRepository;
    private readonly IMapper _mapper;

    public GetMeHandler(IRepositoryBase<User, Guid> userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<Result<Response.GetMe>> Handle(Query.GetMe request, CancellationToken cancellationToken)
    {
        var user =
            await _userRepository.FindByIdAsync(request.UserId, cancellationToken);
        
        if (user is null)
        {
            throw new Exception("User Not Existed !");
        }
        
        var result = _mapper.Map<Response.GetMe>(user);

        return Result.Success(result);
    }
}