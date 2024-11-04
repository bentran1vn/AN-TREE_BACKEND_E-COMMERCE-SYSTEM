using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Identity;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

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
        var query = _userRepository.FindAll(
            x => x.Id.Equals(request.UserId));

        query = query
            .Include(x => x.TransactionList)
                .ThenInclude(x => x.Subscription);

        var user = await query.SingleOrDefaultAsync(cancellationToken);
        
        if (user is null)
        {
            throw new Exception("User Not Existed !");
        }

        var result = new Response.GetMe()
        {
            Email = user.Email,
            Username = user.Username,
            Firstname = user.Firstname,
            Lastname = user.Lastname,
            Phonenumber = user.Phonenumber,
            Subcription = new Response.Subscription()
            {
                SubscriptionName = user.TransactionList.FirstOrDefault(x => x.Status.Equals(1) && !x.IsDeleted)?.Subscription.Name ?? "Mặc định",
                SubscriptionEndDate = user.TransactionList.FirstOrDefault(x => x.Status.Equals(1) && !x.IsDeleted)?.CreatedOnUtc.AddDays(30) ?? DateTimeOffset.Now
            },
            CreatedOnUtc = user.CreatedOnUtc
        };
        
        // var result = _mapper.Map<Response.GetMe>(user);

        return Result.Success(result);
    }
}