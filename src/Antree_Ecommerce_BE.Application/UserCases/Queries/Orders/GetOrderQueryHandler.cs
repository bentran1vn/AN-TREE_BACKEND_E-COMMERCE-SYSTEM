using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Orders;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Antree_Ecommerce_BE.Application.UserCases.Queries.Orders;

public class GetOrderQueryHandler : IQueryHandler<Query.GetOrderQuery, Response.OrderResponse>
{
    private readonly IRepositoryBase<Order, Guid> _orderRepository;
    private readonly IMapper _mapper;

    public GetOrderQueryHandler(IRepositoryBase<Order, Guid> orderRepository, IMapper mapper)
    {
        _orderRepository = orderRepository;
        _mapper = mapper;
    }

    public async Task<Result<Response.OrderResponse>> Handle(Query.GetOrderQuery request, CancellationToken cancellationToken)
    {
        var orderQuery = _orderRepository.FindAll(x => x.Id.Equals(request.Id));

        orderQuery = orderQuery
            .Include(x => x.OrderDetailList)
                .ThenInclude(x => x.OrderDetailFeedback)
                    .ThenInclude(x => x.OrderDetailFeedbackMediaList)
            .Include(x => x.OrderDetailList)
                .ThenInclude(x => x.Product)
            .Include(x => x.User)
            .Include(x => x.Discount);
        
        var order = await orderQuery.SingleOrDefaultAsync(cancellationToken);
        
        var result = _mapper.Map<Response.OrderResponse>(order);

        return Result.Success(result);
    }
}