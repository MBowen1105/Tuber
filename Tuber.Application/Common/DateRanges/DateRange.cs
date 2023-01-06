namespace Tuber.Application.Common.DateRanges;
public static class DateRange
{
    public static int DayOfWeek(DateTime todayUtc)
    {
        if (todayUtc.DayOfWeek == System.DayOfWeek.Sunday)
        {
                return 6;
        }
        return (int)todayUtc.DayOfWeek - 1;
    }

    public static (DateTime, DateTime) CurrentWeek(DateTime todayUtc)
    {
        var dayOfWeek = DayOfWeek(todayUtc);

        var fromDateUtc = todayUtc.AddDays(-dayOfWeek);

        var toDateUtc = fromDateUtc
            .AddDays(7)
            .AddSeconds(-1);

        return (fromDateUtc, toDateUtc);

    }

    public static (DateTime, DateTime) PreviousWeek(DateTime todayUtc)
    {
        var dayOfWeek = DayOfWeek(todayUtc);

        var fromDateUtc = todayUtc.AddDays(-dayOfWeek).AddDays(-7);

        var toDateUtc = fromDateUtc.AddDays(7).AddSeconds(-1);

        return (fromDateUtc, toDateUtc);
    }

    public static (DateTime, DateTime) CurrentMonth(DateTime todayUtc)
    {
        var fromDateUtc = new DateTime(todayUtc.Year, todayUtc.Month, 1);
        var toDateUtc = new DateTime(todayUtc.Year, todayUtc.Month, 1).AddMonths(1).AddSeconds(-1); ;
        return (fromDateUtc, toDateUtc);
    }

    public static (DateTime, DateTime) PreviousMonth(DateTime todayUtc)
    {
        var lastMonth = todayUtc.AddMonths(-1);
        var fromDateUtc = new DateTime(lastMonth.Year, lastMonth.Month, 1);
        var toDateUtc = new DateTime(todayUtc.Year, todayUtc.Month, 1).AddSeconds(-1);
        return (fromDateUtc, toDateUtc);
    }

    public static (DateTime, DateTime) CurrentQuarter(DateTime todayUtc)
    {
        var fromDateUtc = GetCurrentQuarterStartDate(todayUtc);
        var toDateUtc = fromDateUtc.AddMonths(3).AddSeconds(-1);
        return (fromDateUtc, toDateUtc);
    }

    public static (DateTime, DateTime) PreviousQuarter(DateTime todayUtc)
    {
        var fromDateUtc = GetCurrentQuarterStartDate(todayUtc).AddMonths(-3);
        var toDateUtc = GetCurrentQuarterStartDate(todayUtc).AddSeconds(-1);
        return (fromDateUtc, toDateUtc);
    }

    public static (DateTime, DateTime) CurrentYear(DateTime todayUtc)
    {
        var fromDateUtc = new DateTime(todayUtc.Year, 1, 1);
        var toDateUtc = new DateTime(todayUtc.Year, 12, 31).AddDays(1).AddSeconds(-1);
        return (fromDateUtc, toDateUtc);
    }

    public static (DateTime, DateTime) PreviousYear(DateTime todayUtc)
    {
        var fromDateUtc = new DateTime(todayUtc.Year - 1, 1, 1);
        var toDateUtc = new DateTime(todayUtc.Year - 1, 12, 31).AddDays(1).AddSeconds(-1);
        return (fromDateUtc, toDateUtc);
    }

    private static DateTime GetCurrentQuarterStartDate(DateTime todayUtc)
    {
        int quarterNumber = (todayUtc.Month - 1) / 3 + 1;

        return new DateTime(todayUtc.Year, (quarterNumber - 1) * 3 + 1, 1);
    }

}
