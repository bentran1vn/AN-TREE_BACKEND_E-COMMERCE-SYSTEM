using Antree_Ecommerce_BE.Application.DependencyInjection.Extensions;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Dashboards;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Antree_Ecommerce_BE.Application.UserCases.Queries.Dashboards;

public class GetOrderDashboardQueryHandler : IQueryHandler<Query.GetOrderDashboardQuery, List<Response.GetOrderDashboard>>
{
    private readonly IRepositoryBase<Order, Guid> _orderRepository;

    public GetOrderDashboardQueryHandler(IRepositoryBase<Order, Guid> orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public async Task<Result<List<Response.GetOrderDashboard>>> Handle(Query.GetOrderDashboardQuery request, CancellationToken cancellationToken)
    {
        if (request.Month is null && request.Year is null)
        {
            return Result.Failure<List<Response.GetOrderDashboard>>(new Error("500", "Can not empty Week and Month in same time !"));
        }
        
        if (request.Month is not null && request.Year is not null)
        {
            return Result.Failure<List<Response.GetOrderDashboard>>(new Error("500", "Can not appear Week and Month in same time !"));
        }
        
        if (request.Month is not null)
        {
            DateTimeOffset monthDate = DateTimeOffset.ParseExact(request.Month, "MM-yyyy", null);
            
            var result = await _orderRepository
                .FindAll(x =>
                    x.Status == 1 && !x.IsDeleted 
                                  && x.CreatedOnUtc.Month.Equals(monthDate.Month)
                                  && x.CreatedOnUtc.Year.Equals(monthDate.Year)
                ).ToListAsync(cancellationToken);

            // Get the total number of weeks in the month
            int totalWeeks = DashboardExtensions.GetTotalWeeksInMonth(monthDate.DateTime);

            // Create a dictionary of existing order data grouped by week
            var ordersByWeek = result
                .GroupBy(x => DashboardExtensions.GetWeekInMonth(x.CreatedOnUtc.DateTime))
                .ToDictionary(
                    g => g.Key,
                    g => new { Count = g.Count(), Total = g.Sum(x => x.Total) }
                );

            // Generate a complete list of weeks, including empty ones
            var orders = Enumerable.Range(1, totalWeeks)
                .Select(weekNumber => new Response.GetOrderDashboard
                {
                    OrderNumber = ordersByWeek.ContainsKey(weekNumber) ? ordersByWeek[weekNumber].Count : 0,
                    TotalAmount = ordersByWeek.ContainsKey(weekNumber) ? ordersByWeek[weekNumber].Total : 0,
                    No = weekNumber,
                    StartDate = DashboardExtensions.GetWeekStartDate(monthDate.DateTime, weekNumber),
                    EndDate = DashboardExtensions.GetWeekEndDate(monthDate.DateTime, weekNumber)
                })
                .OrderBy(x => x.No)
                .ToList();
            
            return Result.Success(orders);
        }
        
        if (request.Year is not null)
        {
            DateTimeOffset yearDate = DateTimeOffset.ParseExact(request.Year, "yyyy", null);
            
            var result = await _orderRepository
                .FindAll(x =>
                    x.Status == 1 && !x.IsDeleted 
                                  && x.CreatedOnUtc.Year.Equals(yearDate.Year)
                ).ToListAsync(cancellationToken);

            var ordersByMonth = result
                .GroupBy(x => x.CreatedOnUtc.Month)
                .ToDictionary(
                    g => g.Key,
                    g => new { Count = g.Count(), Total = g.Sum(x => x.Total) }
                );

            var orders = Enumerable.Range(1, 12)
                .Select(month => new Response.GetOrderDashboard
                {
                    OrderNumber = ordersByMonth.ContainsKey(month) ? ordersByMonth[month].Count : 0,
                    TotalAmount = ordersByMonth.ContainsKey(month) ? ordersByMonth[month].Total : 0,
                    No = month,
                    StartDate = DashboardExtensions.GetMonthStartDate(yearDate.Year, month),
                    EndDate = DashboardExtensions.GetMonthEndDate(yearDate.Year, month)
                })
                .OrderBy(x => x.No)
                .ToList();
            
            return Result.Success(orders);
        }
        
        return Result.Failure<List<Response.GetOrderDashboard>>(new Error("404", "Can not appear Week and Month in same time !"));
    }
}