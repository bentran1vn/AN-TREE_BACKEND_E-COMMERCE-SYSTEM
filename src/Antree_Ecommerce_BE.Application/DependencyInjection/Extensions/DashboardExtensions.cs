namespace Antree_Ecommerce_BE.Application.DependencyInjection.Extensions;

public static class DashboardExtensions
{
    private static readonly TimeZoneInfo VietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
    
    public static int GetWeekInMonth(DateTime date)
    {
        var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
        return (date.Day - 1) / 7 + 1;
    }

    public static int GetTotalWeeksInMonth(DateTime date)
    {
        var lastDayOfMonth = new DateTime(date.Year, date.Month, 
            DateTime.DaysInMonth(date.Year, date.Month));
        return (lastDayOfMonth.Day - 1) / 7 + 1;
    }
    
    public static DateOnly GetWeekStartDate(DateTime monthDate, int weekNumber)
    {
        // Convert to Vietnam timezone
        var vietnamDate = TimeZoneInfo.ConvertTimeFromUtc(
            monthDate.ToUniversalTime(), 
            VietnamTimeZone
        );
        
        // Get the first day of the month in Vietnam timezone
        var firstDayOfMonth = new DateTime(vietnamDate.Year, vietnamDate.Month, 1);
        
        // Calculate the start of the week
        var daysToAdd = (weekNumber - 1) * 7;
        
        // Get the actual start date
        var weekStart = firstDayOfMonth.AddDays(daysToAdd);
        
        // If weekStart is in the next month, return the first day that is in the current month
        if (weekStart.Month != monthDate.Month)
        {
            weekStart = new DateTime(monthDate.Year, monthDate.Month, 1);
        }
        
        return DateOnly.FromDateTime(weekStart);
    }

    public static DateOnly GetWeekEndDate(DateTime monthDate, int weekNumber)
    {
        // Convert to Vietnam timezone
        var vietnamDate = TimeZoneInfo.ConvertTimeFromUtc(
            monthDate.ToUniversalTime(), 
            VietnamTimeZone
        );
        
        var weekStart = GetWeekStartDate(vietnamDate, weekNumber);
        var proposedEndDate = weekStart.AddDays(6);
        
        // Get the last day of the current month
        var lastDayOfMonth = new DateOnly(vietnamDate.Year, vietnamDate.Month, 
            DateTime.DaysInMonth(vietnamDate.Year, vietnamDate.Month));

        return proposedEndDate <= lastDayOfMonth ? proposedEndDate : lastDayOfMonth;
    }
    
    public static DateOnly GetMonthStartDate(int year, int month)
    {
        return new DateOnly(year, month, 1);
    }

    public static DateOnly GetMonthEndDate(int year, int month)
    {
        return new DateOnly(year, month, DateTime.DaysInMonth(year, month));
    }
}