using Microsoft.AspNetCore.Http;

namespace Tuber.Application.Extensions;
public static class DateTimeExtensions
{
    public static string ToISO8601(this DateTime value) =>
        $"{value.Year.ToString().PadLeft(4, '0')}{value.Month.ToString().PadLeft(2, '0')}{value.Day.ToString().PadLeft(2, '0')}";

    public static int DayOfWeek(this DateTime value) =>
        (value.DayOfWeek == System.DayOfWeek.Sunday)
        ? 6
        : (int)value.DayOfWeek - 1;

    public static DateTime CurrentWeekFrom(this DateTime value) =>
        value
            .AddDays(-value.DayOfWeek());

    public static DateTime CurrentWeekTo(this DateTime value) =>
        value
            .CurrentWeekFrom()
            .AddDays(7)
            .AddSeconds(-1);

    public static DateTime PreviousWeekFrom(this DateTime value) =>
        value.AddDays(-value.DayOfWeek()).AddDays(-7);

    public static DateTime PreviousWeekTo(this DateTime value) =>
        value.PreviousWeekFrom().AddDays(7).AddSeconds(-1);

    public static DateTime CurrentMonthFrom(this DateTime value) =>
        new DateTime(value.Year, value.Month, 1);

    public static DateTime CurrentMonthTo(this DateTime value) =>
         new DateTime(value.Year, value.Month, 1)
            .AddMonths(1).AddSeconds(-1);

    public static DateTime PreviousMonthFrom(this DateTime value)
    {
        var lastMonth = value.AddMonths(-1);
        return new DateTime(lastMonth.Year, lastMonth.Month, 1);
    }

    public static DateTime PreviousMonthTo(this DateTime value) =>
        value.PreviousMonthFrom().AddMonths(1).AddSeconds(-1);

    public static DateTime CurrentQuarterFrom(this DateTime value) =>
        GetCurrentQuarterStartDate(value);

    public static DateTime CurrentQuarterTo(this DateTime value) =>
        value.CurrentQuarterFrom().AddMonths(3).AddSeconds(-1);

    public static DateTime CurrentYearFrom(this DateTime value)=>
        new DateTime(value.Year, 1, 1);

    public static DateTime CurrentYearTo(this DateTime value) =>
        value.CurrentYearFrom().AddYears(1).AddSeconds(-1);

    private static DateTime GetCurrentQuarterStartDate(DateTime todayUtc)
    {
        int quarterNumber = (todayUtc.Month - 1) / 3 + 1;

        return new DateTime(todayUtc.Year, (quarterNumber - 1) * 3 + 1, 1);
    }
}
