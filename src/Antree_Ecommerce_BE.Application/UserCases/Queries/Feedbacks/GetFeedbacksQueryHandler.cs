using System.Linq.Expressions;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Enumerations;
using Antree_Ecommerce_BE.Contract.Services.Feedbacks;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Antree_Ecommerce_BE.Application.UserCases.Queries.Feedbacks;

public class GetFeedbacksQueryHandler : IQueryHandler<Query.GetFeedbacksQuery, PagedResult<Response.FeedbackResonse>>
{
    private readonly IRepositoryBase<OrderDetail, Guid> _orderDetailRepository;
    private readonly IMapper _mapper;

    public GetFeedbacksQueryHandler(IRepositoryBase<OrderDetail, Guid> orderDetailRepository, IMapper mapper)
    {
        _orderDetailRepository = orderDetailRepository;
        _mapper = mapper;
    }

    public async Task<Result<PagedResult<Response.FeedbackResonse>>> Handle(Query.GetFeedbacksQuery request, CancellationToken cancellationToken)
    {
        var feedbacksQuery = _orderDetailRepository.FindAll(x => 
                x.OrderDetailFeedbackId != null &&
                x.ProductId.Equals(request.ProductId));

        feedbacksQuery = feedbacksQuery
            .Include(x => x.Product)
            .Include(x => x.Order)
                .ThenInclude(o => o.User)
            .Include(x => x.OrderDetailFeedback)
                .ThenInclude(odf => odf.OrderDetailFeedbackMediaList);
        
        feedbacksQuery = request.SortOrder == SortOrder.Descending
            ? feedbacksQuery.OrderByDescending(GetSortProperty(request))
            : feedbacksQuery.OrderBy(GetSortProperty(request));

        var products = await PagedResult<OrderDetail>.CreateAsync(feedbacksQuery,
            request.PageIndex,
            request.PageSize);

        var result = _mapper.Map<PagedResult<Response.FeedbackResonse>>(products);
        
        return Result.Success(result);
    }
    
    private static Expression<Func<OrderDetail, object>> GetSortProperty(Query.GetFeedbacksQuery request)
        => request.SortColumn?.ToLower() switch
        {
            "rating" => orderDetail => orderDetail.OrderDetailFeedback.Rating,
            _ => orderDetail => orderDetail.Id
            //_ => product => product.CreatedDate // Default Sort Descending on CreatedDate column
        };
}