using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Orders;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;
using AutoMapper;

namespace Antree_Ecommerce_BE.Application.UserCases.Queries.Orders;

public class GetCustomerOrdersQueryHandler : IQueryHandler<Query.GetCustomerOrdersQuery, PagedResult<Response.CustomerOrdersResponse>>
{
    private readonly IRepositoryBase<Order, Guid> _orderRepository;
    private readonly IMapper _mapper;

    public GetCustomerOrdersQueryHandler(IRepositoryBase<Order, Guid> orderRepository, IMapper mapper)
    {
        _orderRepository = orderRepository;
        _mapper = mapper;
        
    }

    public async Task<Result<PagedResult<Response.CustomerOrdersResponse>>> Handle(Query.GetCustomerOrdersQuery request, CancellationToken cancellationToken)
    {
        var ordersQuery = _orderRepository.FindAll(
            x => x.UserId.Equals(request.CustomerId), 
            x => x.Discount!);

        ordersQuery = !request.NotFeedback ? ordersQuery : ordersQuery.Where(x => !x.IsFeedback && x.Status.Equals(1));
        
        var orders = await PagedResult<Order>.CreateAsync(ordersQuery,
            request.PageIndex,
            request.PageSize);
        
        var result = _mapper.Map<PagedResult<Response.CustomerOrdersResponse>>(orders);
        
        return Result.Success(result);
    }
}