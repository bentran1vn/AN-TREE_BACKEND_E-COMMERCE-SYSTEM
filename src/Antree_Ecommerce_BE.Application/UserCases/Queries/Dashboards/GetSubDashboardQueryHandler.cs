using Antree_Ecommerce_BE.Application.DependencyInjection.Extensions;
using Antree_Ecommerce_BE.Contract.Abstractions.Messages;
using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Dashboards;
using Antree_Ecommerce_BE.Domain.Abstractions.Repositories;
using Antree_Ecommerce_BE.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Antree_Ecommerce_BE.Application.UserCases.Queries.Dashboards;

public class GetSubDashboardQueryHandler : IQueryHandler<Query.GetSubDashboardQuery, List<Response.GetSubDashboard>>
{
    private readonly IRepositoryBase<Transaction, Guid> _transactionRepository;

    public GetSubDashboardQueryHandler(IRepositoryBase<Transaction, Guid> transactionRepository)
    {
        _transactionRepository = transactionRepository;
    }

    public async Task<Result<List<Response.GetSubDashboard>>> Handle(Query.GetSubDashboardQuery request, CancellationToken cancellationToken)
    {
        if (request is { Month: "", Year: "" })
        {
            return Result.Failure<List<Response.GetSubDashboard>>(new Error("500", "Can not empty Week and Month in same time !"));
        }
        
        if (request.Month != "" && request.Year != "")
        {
            return Result.Failure<List<Response.GetSubDashboard>>(new Error("500", "Can not appear Week and Month in same time !"));
        }

        if (request.Month != "")
        {
            DateTimeOffset monthDate = DateTimeOffset.ParseExact(request.Month, "MM-yyyy", null);
            
            TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
            
            var startOfMonth = new DateTimeOffset(monthDate.Year, monthDate.Month, 1, 0, 0, 0, vietnamTimeZone.GetUtcOffset(monthDate.DateTime));
            var endOfMonth = startOfMonth.AddMonths(1);
            
            var result = await _transactionRepository
                .FindAll(x =>
                        x.Status == 1 && !x.IsDeleted 
                                      && x.CreatedOnUtc >= startOfMonth.UtcDateTime
                                      && x.CreatedOnUtc < endOfMonth.UtcDateTime,
                    x => x.Subscription
                ).ToListAsync(cancellationToken);

            // Get the total number of weeks in the month
            int totalWeeks = DashboardExtensions.GetTotalWeeksInMonth(monthDate.DateTime);
            
            var subscriptionNames = result
                .Select(x => x.Subscription.Name)
                .Distinct()
                .ToList();
            
            var transactionsByWeekAndSub = result
                .GroupBy(x => new 
                { 
                    Week = DashboardExtensions.GetWeekInMonth(
                        TimeZoneInfo.ConvertTimeFromUtc(x.CreatedOnUtc.DateTime, vietnamTimeZone)
                    ),
                    SubName = x.Subscription.Name 
                })
                .ToDictionary(
                    g => (g.Key.Week, g.Key.SubName),
                    g => new 
                    { 
                        Count = g.Count().ToString(),
                        Total = g.Sum(x => x.Total).ToString()
                    }
                );
            
            var dashboard = new List<Response.GetSubDashboard>();

            for (int weekNumber = 1; weekNumber <= totalWeeks; weekNumber++)
            {
                foreach (var subscriptionName in subscriptionNames)
                {
                    var hasData = transactionsByWeekAndSub.TryGetValue((weekNumber, subscriptionName), out var data);

                    dashboard.Add(new Response.GetSubDashboard
                    {
                        No = weekNumber,
                        StartDate = DashboardExtensions.GetWeekStartDate(monthDate.DateTime, weekNumber),
                        EndDate = DashboardExtensions.GetWeekEndDate(monthDate.DateTime, weekNumber),
                        SubscriptionName = subscriptionName,
                        SubscriptionNumber = hasData ? data.Count : "0",
                        SubscriptionTotal = hasData ? data.Total : "0"
                    });
                }
            }
            
            return Result.Success(dashboard.OrderBy(x => x.No).ThenBy(x => x.SubscriptionName).ToList());
        }

        if (request.Year != "")
        {
            DateTimeOffset yearDate = DateTimeOffset.ParseExact(request.Year, "yyyy", null);
            TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
        
        // Calculate UTC range for the given year in Vietnam timezone
        var startOfYear = new DateTimeOffset(yearDate.Year, 1, 1, 0, 0, 0, vietnamTimeZone.GetUtcOffset(yearDate.DateTime));
        var endOfYear = startOfYear.AddYears(1);
        
        var result = await _transactionRepository
            .FindAll(x =>
                    x.Status == 1 && !x.IsDeleted 
                                  && x.CreatedOnUtc >= startOfYear.UtcDateTime
                                  && x.CreatedOnUtc < endOfYear.UtcDateTime,
                x => x.Subscription
            ).ToListAsync(cancellationToken);

        var subscriptionNames = result
            .Select(x => x.Subscription.Name)
            .Distinct()
            .ToList();
        
        // Group by month instead of week
        var transactionsByMonthAndSub = result
            .GroupBy(x => new 
            { 
                Month = TimeZoneInfo.ConvertTimeFromUtc(x.CreatedOnUtc.DateTime, vietnamTimeZone).Month,
                SubName = x.Subscription.Name 
            })
            .ToDictionary(
                g => (g.Key.Month, g.Key.SubName),
                g => new 
                { 
                    Count = g.Count().ToString(),
                    Total = g.Sum(x => x.Total).ToString()
                }
            );
        
        var dashboard = new List<Response.GetSubDashboard>();

        // Loop through all 12 months
        for (int month = 1; month <= 12; month++)
        {
            foreach (var subscriptionName in subscriptionNames)
            {
                var hasData = transactionsByMonthAndSub.TryGetValue((month, subscriptionName), out var data);

                dashboard.Add(new Response.GetSubDashboard
                {
                    No = month,
                    StartDate = new DateOnly(yearDate.Year, month, 1),
                    EndDate = new DateOnly(yearDate.Year, month, DateTime.DaysInMonth(yearDate.Year, month)),
                    SubscriptionName = subscriptionName,
                    SubscriptionNumber = hasData ? data.Count : "0",
                    SubscriptionTotal = hasData ? data.Total : "0"
                });
            }
        }
        
        return Result.Success(dashboard.OrderBy(x => x.No).ThenBy(x => x.SubscriptionName).ToList());
        }

        return Result.Failure<List<Response.GetSubDashboard>>(new Error("500", "Invalid request"));
    }
}