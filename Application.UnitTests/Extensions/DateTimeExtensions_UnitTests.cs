using FluentAssertions;
using Tuber.Application.Extensions;
using Tuber.Core.Validation;

namespace Application.UnitTests.Extensions;
internal class DateTimeExtensions_UnitTests
{
    [Test]
    [TestCase("2022-12-26", 0)] //Monday
    [TestCase("2022-12-27", 1)]
    [TestCase("2022-12-28", 2)]
    [TestCase("2022-12-29", 3)]
    [TestCase("2022-12-30", 4)]
    [TestCase("2022-12-31", 5)]
    [TestCase("2023-01-01", 6)]//Sunday
    public void DayOfWeek_HasMondayAsFirstDay(DateTime value, int dayNum) =>
        value.DayOfWeek().Should().Be(dayNum);

    [Test, Parallelizable]
    [TestCase("11-May-1963 17:15:00", "19630511")]
    [TestCase("1-Dec-2022 00:00:00", "20221201")]
    public void ValidDateTime_ConvertsToCorrectISO8601StyleDate(
        DateTime value, string ISO8601Value) => value.ToISO8601().Should().Be(ISO8601Value);

    [Test, Parallelizable]
    [TestCase("2022-12-26", "2022-12-26 00:00:00")]
    [TestCase("2022-12-28", "2022-12-26 00:00:00")]
    [TestCase("2023-01-01", "2022-12-26 00:00:00")]
    public void CurrentWeekFrom_ReturnsCorrectDate(
        DateTime value, DateTime correctDate) =>
       value.CurrentWeekFrom().Should().Be(correctDate);

    [Test, Parallelizable]
    [TestCase("2022-12-26", "2023-01-01 23:59:59")]
    [TestCase("2022-12-28", "2023-01-01 23:59:59")]
    [TestCase("2023-01-01", "2023-01-01 23:59:59")]
    public void CurrentWeekTo_ReturnsCorrectDate(
        DateTime value, DateTime correctDate)
    {
        value.CurrentWeekTo().Should().Be(correctDate);
    }

    [Test, Parallelizable]
    [TestCase("2022-12-26", "2022-12-19 00:00:00")]
    [TestCase("2022-12-28", "2022-12-19 00:00:00")]
    [TestCase("2023-01-01", "2022-12-19 00:00:00")]
    public void PreviousWeekFrom_ReturnsCorrectDate(
        DateTime value, DateTime correctDate) =>
        value.PreviousWeekFrom().Should().Be(correctDate);

    [Test, Parallelizable]
    [TestCase("2022-12-26", "2022-12-25 23:59:59")]
    [TestCase("2022-12-28", "2022-12-25 23:59:59")]
    [TestCase("2023-01-01", "2022-12-25 23:59:59")]
    public void PreviousWeekTo_ReturnsCorrectDate(
           DateTime value, DateTime correctDate) =>
           value.PreviousWeekTo().Should().Be(correctDate);

    [Test, Parallelizable]
    [TestCase("2022-01-15", "2022-01-01 00:00:00")]
    [TestCase("2022-02-15", "2022-02-01 00:00:00")]
    [TestCase("2020-02-15", "2020-02-01 00:00:00")]//Leap year
    [TestCase("2022-03-15", "2022-03-01 00:00:00")]
    [TestCase("2022-04-15", "2022-04-01 00:00:00")]
    [TestCase("2022-05-15", "2022-05-01 00:00:00")]
    [TestCase("2022-06-15", "2022-06-01 00:00:00")]
    [TestCase("2022-07-15", "2022-07-01 00:00:00")]
    [TestCase("2022-08-15", "2022-08-01 00:00:00")]
    [TestCase("2022-09-15", "2022-09-01 00:00:00")]
    [TestCase("2022-10-15", "2022-10-01 00:00:00")]
    [TestCase("2022-11-15", "2022-11-01 00:00:00")]
    [TestCase("2022-12-15", "2022-12-01 00:00:00")]
    public void CurrentMonthFrom_ReturnsCorrectFromDate(
        DateTime value, DateTime correctDate) =>
        value.CurrentMonthFrom().Should().Be(correctDate);

    [Test, Parallelizable]
    [TestCase("2022-01-15", "2022-01-31 23:59:59")]
    [TestCase("2022-02-15", "2022-02-28 23:59:59")]
    [TestCase("2020-02-15", "2020-02-29 23:59:59")]//Leap year
    [TestCase("2022-03-15", "2022-03-31 23:59:59")]
    [TestCase("2022-04-15", "2022-04-30 23:59:59")]
    [TestCase("2022-05-15", "2022-05-31 23:59:59")]
    [TestCase("2022-06-15", "2022-06-30 23:59:59")]
    [TestCase("2022-07-15", "2022-07-31 23:59:59")]
    [TestCase("2022-08-15", "2022-08-31 23:59:59")]
    [TestCase("2022-09-15", "2022-09-30 23:59:59")]
    [TestCase("2022-10-15", "2022-10-31 23:59:59")]
    [TestCase("2022-11-15", "2022-11-30 23:59:59")]
    [TestCase("2022-12-15", "2022-12-31 23:59:59")]
    public void CurrentMonthTo_ReturnsCorrectToDate(
       DateTime value, DateTime correctDate) =>
       value.CurrentMonthTo().Should().Be(correctDate);


    [Test, Parallelizable]
    [TestCase("2022-01-15", "2021-12-01 00:00:00")]
    [TestCase("2022-02-15", "2022-01-01 00:00:00")]
    [TestCase("2022-03-15", "2022-02-01 00:00:00")]
    [TestCase("2022-04-15", "2022-03-01 00:00:00")]
    [TestCase("2022-05-15", "2022-04-01 00:00:00")]
    [TestCase("2022-06-15", "2022-05-01 00:00:00")]
    [TestCase("2022-07-15", "2022-06-01 00:00:00")]
    [TestCase("2022-08-15", "2022-07-01 00:00:00")]
    [TestCase("2022-09-15", "2022-08-01 00:00:00")]
    [TestCase("2022-10-15", "2022-09-01 00:00:00")]
    [TestCase("2022-11-15", "2022-10-01 00:00:00")]
    [TestCase("2022-12-15", "2022-11-01 00:00:00")]
    public void PreviousMonthFrom_ReturnsCorrectFromDate(
        DateTime value, DateTime correctDate)
    {
        value.PreviousMonthFrom().Should().Be(correctDate);
    }

    [TestCase("2022-01-15", "2021-12-31 23:59:59")]
    [TestCase("2022-02-15", "2022-01-31 23:59:59")]
    [TestCase("2022-03-15", "2022-02-28 23:59:59")]
    [TestCase("2022-04-15", "2022-03-31 23:59:59")]
    [TestCase("2022-05-15", "2022-04-30 23:59:59")]
    [TestCase("2022-06-15", "2022-05-31 23:59:59")]
    [TestCase("2022-07-15", "2022-06-30 23:59:59")]
    [TestCase("2022-08-15", "2022-07-31 23:59:59")]
    [TestCase("2022-09-15", "2022-08-31 23:59:59")]
    [TestCase("2022-10-15", "2022-09-30 23:59:59")]
    [TestCase("2022-11-15", "2022-10-31 23:59:59")]
    [TestCase("2022-12-15", "2022-11-30 23:59:59")]
    public void PreviousMonthTo_ReturnsCorrectToDate(
        DateTime value, DateTime correctDate)
    {
        value.PreviousMonthTo().Should().Be(correctDate);
    }

    [Test, Parallelizable]
    [TestCase("2022-01-15", "2022-01-01 00:00:00")]
    [TestCase("2022-05-15", "2022-04-01 00:00:00")]
    [TestCase("2022-08-15", "2022-07-01 00:00:00")]
    [TestCase("2022-11-15", "2022-10-01 00:00:00")]
    public void CurrentQuarterFrom_ReturnsCorrectFromDate(
        DateTime value, DateTime correctDate)
    {
        value.CurrentQuarterFrom().Should().Be(correctDate);
    }

    [Test, Parallelizable]
    [TestCase("2022-01-15", "2022-03-31 23:59:59")]
    [TestCase("2022-05-15", "2022-06-30 23:59:59")]
    [TestCase("2022-08-15", "2022-09-30 23:59:59")]
    [TestCase("2022-11-15", "2022-12-31 23:59:59")]
    public void CurrentQuarterTo_ReturnsCorrectToDate(
        DateTime value, DateTime correctDate)
    {
        value.CurrentQuarterTo().Should().Be(correctDate);
    }

    [Test, Parallelizable]
    [TestCase("2022-01-01", "2022-01-01 00:00:00")]
    [TestCase("2022-06-15", "2022-01-01 00:00:00")]
    [TestCase("2022-12-31", "2022-01-01 00:00:00")]
    public void CurrentYear_ReturnsCorrectFromDate(
        DateTime value, DateTime correctDate)=> value.CurrentYearFrom().Should().Be(correctDate);

    [Test, Parallelizable]
    [TestCase("2022-01-01", "2022-12-31 23:59:59")]
    [TestCase("2022-06-15", "2022-12-31 23:59:59")]
    [TestCase("2022-12-31", "2022-12-31 23:59:59")]
    public void PreviousYear_ReturnsCorrectToDate(
        DateTime value, DateTime correctDate)
    => value.CurrentYearTo().Should().Be(correctDate);
}
