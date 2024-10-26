using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Transactions;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;
using AutoMapper;

namespace Antree_Ecommerce_BE.Application.UserCases.Queries.Transactions;

public class GetAllTransactionsQueryHandler : IQueryHandler<Query.GetAllTransactionsQuery, PagedResult<Response.GetAllTransaction>>
{
    private readonly IRepositoryBase<Domain.Entities.Transaction, Guid> _transactionRepository;
    private readonly IMapper _mapper;

    public GetAllTransactionsQueryHandler(IRepositoryBase<Transaction, Guid> transactionRepository, IMapper mapper)
    {
        _transactionRepository = transactionRepository;
        _mapper = mapper;
        
    }

    public async Task<Result<PagedResult<Response.GetAllTransaction>>> Handle(Query.GetAllTransactionsQuery request, CancellationToken cancellationToken)
    {
        var query = request.UserId is null ? 
            _transactionRepository.FindAll(null
                , x => x.User, x => x.Subscription) : 
            _transactionRepository.FindAll(x=> x.UserId.Equals(request.UserId)
                , x => x.User, x => x.Subscription);

        query = string.IsNullOrWhiteSpace(request.SearchTerm)
            ? query
            : query.Where(
                x => x.User.Email.ToLower().Contains(request.SearchTerm.ToLower()) ||
                     x.Subscription.Name.ToLower().Contains(request.SearchTerm.ToLower()));

        query = query.OrderByDescending(x => x.CreatedOnUtc);
        
        var trans = await PagedResult<Transaction>.CreateAsync(query,
            request.PageIndex,
            request.PageSize);
        
        var result = _mapper.Map<PagedResult<Response.GetAllTransaction>>(trans);
        return Result.Success(result);
    }
}