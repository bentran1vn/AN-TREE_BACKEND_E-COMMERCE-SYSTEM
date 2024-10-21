using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Orders;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Antree_Ecommerce_BE.Application.UserCases.Queries.Orders;

public class GetAdminOrdersQueryHandler: IQueryHandler<Query.GetAdminOrdersQuery, PagedResult<Response.AdminOrdersResponse>>
{
    private readonly IRepositoryBase<Order, Guid> _orderRepository;
    private readonly IRepositoryBase<OrderDetail, Guid> _orderDetailRepository;
    private readonly IRepositoryBase<Antree_Ecommerce_BE.Domain.Entities.Vendor, Guid> _vendorRepository;
    private readonly IMapper _mapper;

    public GetAdminOrdersQueryHandler(IRepositoryBase<Order, Guid> orderRepository, IRepositoryBase<OrderDetail, Guid> orderDetailRepository, IMapper mapper, IRepositoryBase<Domain.Entities.Vendor, Guid> vendorRepository)
    {
        _orderRepository = orderRepository;
        _orderDetailRepository = orderDetailRepository;
        _mapper = mapper;
        _vendorRepository = vendorRepository;
    }

    public async Task<Result<PagedResult<Response.AdminOrdersResponse>>> Handle(Query.GetAdminOrdersQuery request, CancellationToken cancellationToken)
    {
        // var orderDetailQuery = await  _orderDetailRepository
        //     .FindAll(null,x => x.Product)
        //     .ToListAsync(cancellationToken);
        //
        // var orders = await _orderRepository.FindAll().ToListAsync(cancellationToken);
        // var vendors = await _vendorRepository.FindAll().ToListAsync(cancellationToken);
        //
        // var ordersTotal = orderDetailQuery
        //     .GroupBy(x => new { x.OrderId, x.Product.VendorId })
        // .Select(g => new Response.AdminOrdersResponse (
        //     Guid.NewGuid(), 
        //     g.Key.OrderId,
        //     g.Sum(x => x.ProductQuantity * x.ProductPriceDiscount),
        //     orders.FirstOrDefault(o => o.Id == g.Key.OrderId)!.Status,
        //     orders.FirstOrDefault(o => o.Id == g.Key.OrderId)!.CreatedOnUtc,
        //     vendors.FirstOrDefault(o => o.Id == g.Key.VendorId)!.Name
        // )).ToList();

        var query = _orderDetailRepository
            .FindAll()
            .Include(x => x.Product)
            .ThenInclude(p => p.Vendor)
            .Include(x => x.Order)
            .GroupBy(x => new { x.OrderId, VendorId = x.Product.VendorId })
            .Select(g => new Response.AdminOrdersResponse
            {
                OrderId = g.Key.OrderId,
                VendorId = g.Key.VendorId,
                Total = g.Sum(x => x.ProductQuantity * x.ProductPriceDiscount),
                Status = g.First().Order.Status,
                CreatedOnUtc = g.First().Order.CreatedOnUtc,
                VendorName = g.First().Product.Vendor.Name
            }).OrderByDescending(o => o.CreatedOnUtc);
           
         //Get total count
        var totalCount = await query.CountAsync(cancellationToken);

         //Apply paging
         var pagedResults = await query
             .Skip((request.PageIndex - 1) * request.PageSize)
             .Take(request.PageSize)
             .ToListAsync(cancellationToken);
         
         var result = PagedResult<Response.AdminOrdersResponse>.Create(
             pagedResults, request.PageIndex,
             request.PageSize, totalCount);
        
        return Result.Success(result);
    }
}