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
        if (String.IsNullOrEmpty(request.Month) && String.IsNullOrEmpty(request.Year))
        {
            return Result.Failure<List<Response.GetSubDashboard>>(new Error("500", "Can not empty Week and Month in same time !"));
        }
        
        if (!String.IsNullOrEmpty(request.Month) && !String.IsNullOrEmpty(request.Year))
        {
            return Result.Failure<List<Response.GetSubDashboard>>(new Error("500", "Can not appear Week and Month in same time !"));
        }

        if (!String.IsNullOrEmpty(request.Month))
        {
            DateTimeOffset monthDate = DateTimeOffset.ParseExact(request.Month, "MM-yyyy", null);
            TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
            
            // Convert month boundaries to Vietnam time, then to UTC for comparison
            var startOfMonthVN = new DateTimeOffset(monthDate.Year, monthDate.Month, 1, 0, 0, 0, vietnamTimeZone.GetUtcOffset(monthDate.DateTime));
            var endOfMonthVN = startOfMonthVN.AddMonths(1);
            
            var startOfMonthUtc = startOfMonthVN.ToUniversalTime();
            var endOfMonthUtc = endOfMonthVN.ToUniversalTime();

            var result = await _transactionRepository
                .FindAll(x =>
                        x.Status == 1 && !x.IsDeleted 
                        && x.CreatedOnUtc >= startOfMonthUtc.DateTime
                        && x.CreatedOnUtc < endOfMonthUtc.DateTime,
                    x => x.Subscription
                ).ToListAsync(cancellationToken);

            int totalWeeks = DashboardExtensions.GetTotalWeeksInMonth(monthDate.DateTime);
            
            var subscriptionNames = result
                .Select(x => x.Subscription.Name)
                .Distinct()
                .ToList();
            
            // Convert CreatedOnUtc to Vietnam time ONCE before grouping
            var transactionsByWeekAndSub = result
                .GroupBy(x => new 
                { 
                    Week = DashboardExtensions.GetWeekInMonth(
                        TimeZoneInfo.ConvertTime(x.CreatedOnUtc, vietnamTimeZone).DateTime
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

            // Rest of the code remains the same
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

        if (!String.IsNullOrEmpty(request.Year))
        {
            DateTimeOffset yearDate = DateTimeOffset.ParseExact(request.Year, "yyyy", null);
            TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");

            // Calculate start and end of year in Vietnam timezone first
            var startOfYearVN = new DateTimeOffset(yearDate.Year, 1, 1, 0, 0, 0, vietnamTimeZone.GetUtcOffset(new DateTime(yearDate.Year, 1, 1)));
            var endOfYearVN = new DateTimeOffset(yearDate.Year + 1, 1, 1, 0, 0, 0, vietnamTimeZone.GetUtcOffset(new DateTime(yearDate.Year + 1, 1, 1)));

            // Convert to UTC for database query
            var startOfYearUtc = startOfYearVN.ToUniversalTime();
            var endOfYearUtc = endOfYearVN.ToUniversalTime();

            var result = await _transactionRepository
                .FindAll(x =>
                        x.Status == 1 && !x.IsDeleted 
                                      && x.CreatedOnUtc >= startOfYearUtc.DateTime
                                      && x.CreatedOnUtc < endOfYearUtc.DateTime,
                    x => x.Subscription
                ).ToListAsync(cancellationToken);

            var subscriptionNames = result
                .Select(x => x.Subscription.Name)
                .Distinct()
                .ToList();

            // Convert CreatedOnUtc to Vietnam time ONCE before grouping
            var transactionsByMonthAndSub = result
                .GroupBy(x => new 
                { 
                    Month = TimeZoneInfo.ConvertTime(x.CreatedOnUtc, vietnamTimeZone).Month,
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
                    var startDate = new DateOnly(yearDate.Year, month, 1);
                    var endDate = new DateOnly(yearDate.Year, month, DateTime.DaysInMonth(yearDate.Year, month));

                    dashboard.Add(new Response.GetSubDashboard
                    {
                        No = month,
                        StartDate = startDate,
                        EndDate = endDate,
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