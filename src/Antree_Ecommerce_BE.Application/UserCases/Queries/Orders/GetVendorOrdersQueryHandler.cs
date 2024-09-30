using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Orders;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Antree_Ecommerce_BE.Application.UserCases.Queries.Orders;

public class GetVendorOrdersQueryHandler : IQueryHandler<Query.GetVendorOrdersQuery, PagedResult<Response.VendorOrdersResponse>>
{
    private readonly IRepositoryBase<Order, Guid> _orderRepository;
    private readonly IRepositoryBase<OrderDetail, Guid> _orderDetailRepository;
    private readonly IMapper _mapper;

    public GetVendorOrdersQueryHandler(IRepositoryBase<Order, Guid> orderRepository, IMapper mapper, IRepositoryBase<OrderDetail, Guid> orderDetailRepository)
    {
        _orderRepository = orderRepository;
        _mapper = mapper;
        _orderDetailRepository = orderDetailRepository;
    }

    public async Task<Result<PagedResult<Response.VendorOrdersResponse>>> Handle(Query.GetVendorOrdersQuery request, CancellationToken cancellationToken)
    {
        var ordersList = _orderDetailRepository.FindAll(
            x => x.Product.VendorId.Equals(request.VendorId),
            x=> x.Product)
            .Select(x => x.OrderId).Distinct();
        
        var ordersQuery = _orderRepository.FindAll(x => ordersList.Contains(x.Id),
            x => x.User, x => x.Discount!);
        
        ordersQuery = !request.NotFeedback ? ordersQuery : ordersQuery.Where(x => !x.IsFeedback && x.Status.Equals(2));
        
        var orders = await PagedResult<Order>.CreateAsync(ordersQuery,
            request.PageIndex,
            request.PageSize);
        
        var result = _mapper.Map<PagedResult<Response.VendorOrdersResponse>>(orders);
        
        return Result.Success(result);
    }
}