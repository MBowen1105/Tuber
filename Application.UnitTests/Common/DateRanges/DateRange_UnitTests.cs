using FluentAssertions;
using Tuber.Application.Common.DateRanges;

namespace Application.UnitTests.Common.DateRanges;
internal class DateRange_UnitTests
{
    [Test]
    [TestCase("2022-12-26", 0)] //Monday
    [TestCase("2022-12-27", 1)]
    [TestCase("2022-12-28", 2)]
    [TestCase("2022-12-29", 3)]
    [TestCase("2022-12-30", 4)]
    [TestCase("2022-12-31", 5)]
    [TestCase("2023-01-01", 6)]//Sunday
    public void DayOfWeek_HasMondayAsFirstDay(DateTime testDate, int dayNum)
    {
        var sut = DateRange.DayOfWeek(testDate);

        sut.Should().Be(dayNum);
    }


    [Test, Parallelizable]
    [TestCase("2022-12-26", "2022-12-26 00:00:00", "2023-01-01 23:59:59")]
    [TestCase("2022-12-28", "2022-12-26 00:00:00", "2023-01-01 23:59:59")]
    [TestCase("2023-01-01", "2022-12-26 00:00:00", "2023-01-01 23:59:59")]
    public void CurrentWeek_ReturnsCorrectFromToDates(
        DateTime today, DateTime correctFromDateTime, DateTime correctToDateTime)
    {
        var (fromDate, toDate) = DateRange.CurrentWeek(today);

        fromDate.Should().Be(correctFromDateTime);
        toDate.Should().Be(correctToDateTime);
    }

    [Test, Parallelizable]
    [TestCase("2022-12-26", "2022-12-19 00:00:00", "2022-12-25 23:59:59")]
    [TestCase("2022-12-28", "2022-12-19 00:00:00", "2022-12-25 23:59:59")]
    [TestCase("2023-01-01", "2022-12-19 00:00:00", "2022-12-25 23:59:59")]
    public void PreviousWeek_ReturnsCorrectFromToDates(
        DateTime today, DateTime correctFromDateTime, DateTime correctToDateTime)
    {
        var (fromDate, toDate) = DateRange.PreviousWeek(today);

        fromDate.Should().Be(correctFromDateTime);
        toDate.Should().Be(correctToDateTime);
    }

    [Test, Parallelizable]
    [TestCase("2022-01-15", "2022-01-01 00:00:00", "2022-01-31 23:59:59")]
    [TestCase("2022-02-15", "2022-02-01 00:00:00", "2022-02-28 23:59:59")]
    [TestCase("2020-02-15", "2020-02-01 00:00:00", "2020-02-29 23:59:59")]//Leap year
    [TestCase("2022-03-15", "2022-03-01 00:00:00", "2022-03-31 23:59:59")]
    [TestCase("2022-04-15", "2022-04-01 00:00:00", "2022-04-30 23:59:59")]
    [TestCase("2022-05-15", "2022-05-01 00:00:00", "2022-05-31 23:59:59")]
    [TestCase("2022-06-15", "2022-06-01 00:00:00", "2022-06-30 23:59:59")]
    [TestCase("2022-07-15", "2022-07-01 00:00:00", "2022-07-31 23:59:59")]
    [TestCase("2022-08-15", "2022-08-01 00:00:00", "2022-08-31 23:59:59")]
    [TestCase("2022-09-15", "2022-09-01 00:00:00", "2022-09-30 23:59:59")]
    [TestCase("2022-10-15", "2022-10-01 00:00:00", "2022-10-31 23:59:59")]
    [TestCase("2022-11-15", "2022-11-01 00:00:00", "2022-11-30 23:59:59")]
    [TestCase("2022-12-15", "2022-12-01 00:00:00", "2022-12-31 23:59:59")]
    public void CurrentMonth_ReturnsCorrectFromToDates(
        DateTime today, DateTime correctFromDateTime, DateTime correctToDateTime)
    {
        var (fromDate, toDate) = DateRange.CurrentMonth(today);

        fromDate.Should().Be(correctFromDateTime);
        toDate.Should().Be(correctToDateTime);
    }

    [Test, Parallelizable]
    [TestCase("2022-01-15", "2021-12-01 00:00:00", "2021-12-31 23:59:59")]
    [TestCase("2022-02-15", "2022-01-01 00:00:00", "2022-01-31 23:59:59")]
    [TestCase("2022-03-15", "2022-02-01 00:00:00", "2022-02-28 23:59:59")]
    [TestCase("2022-04-15", "2022-03-01 00:00:00", "2022-03-31 23:59:59")]
    [TestCase("2022-05-15", "2022-04-01 00:00:00", "2022-04-30 23:59:59")]
    [TestCase("2022-06-15", "2022-05-01 00:00:00", "2022-05-31 23:59:59")]
    [TestCase("2022-07-15", "2022-06-01 00:00:00", "2022-06-30 23:59:59")]
    [TestCase("2022-08-15", "2022-07-01 00:00:00", "2022-07-31 23:59:59")]
    [TestCase("2022-09-15", "2022-08-01 00:00:00", "2022-08-31 23:59:59")]
    [TestCase("2022-10-15", "2022-09-01 00:00:00", "2022-09-30 23:59:59")]
    [TestCase("2022-11-15", "2022-10-01 00:00:00", "2022-10-31 23:59:59")]
    [TestCase("2022-12-15", "2022-11-01 00:00:00", "2022-11-30 23:59:59")]
    public void PreviousMonth_ReturnsCorrectFromToDates(
        DateTime today, DateTime correctFromDateTime, DateTime correctToDateTime)
    {
        var (fromDate, toDate) = DateRange.PreviousMonth(today);

        fromDate.Should().Be(correctFromDateTime);
        toDate.Should().Be(correctToDateTime);
    }

    [Test, Parallelizable]
    [TestCase("2022-01-15", "2022-01-01 00:00:00", "2022-03-31 23:59:59")]
    [TestCase("2022-05-15", "2022-04-01 00:00:00", "2022-06-30 23:59:59")]
    [TestCase("2022-08-15", "2022-07-01 00:00:00", "2022-09-30 23:59:59")]
    [TestCase("2022-11-15", "2022-10-01 00:00:00", "2022-12-31 23:59:59")]
    public void CurrentQuarter_ReturnsCorrectFromToDates(
        DateTime today, DateTime correctFromDateTime, DateTime correctToDateTime)
    {
        var (fromDate, toDate) = DateRange.CurrentQuarter(today);

        fromDate.Should().Be(correctFromDateTime);
        toDate.Should().Be(correctToDateTime);
    }

    [Test, Parallelizable]
    [TestCase("2022-01-15", "2021-10-01 00:00:00", "2021-12-31 23:59:59")]
    [TestCase("2022-05-15", "2022-01-01 00:00:00", "2022-03-31 23:59:59")]
    [TestCase("2022-08-15", "2022-04-01 00:00:00", "2022-06-30 23:59:59")]
    [TestCase("2022-11-15", "2022-07-01 00:00:00", "2022-09-30 23:59:59")]
    public void PreviousQuarter_ReturnsCorrectFromToDates(
        DateTime today, DateTime correctFromDateTime, DateTime correctToDateTime)
    {
        var (fromDate, toDate) = DateRange.PreviousQuarter(today);

        fromDate.Should().Be(correctFromDateTime);
        toDate.Should().Be(correctToDateTime);
    }

    [Test, Parallelizable]
    [TestCase("2022-01-01", "2022-01-01 00:00:00", "2022-12-31 23:59:59")]
    [TestCase("2022-06-15", "2022-01-01 00:00:00", "2022-12-31 23:59:59")]
    [TestCase("2022-12-31", "2022-01-01 00:00:00", "2022-12-31 23:59:59")]
    public void CurrentYear_ReturnsCorrectFromToDates(
        DateTime today, DateTime correctFromDateTime, DateTime correctToDateTime)
    {
        var (fromDate, toDate) = DateRange.CurrentYear(today);

        fromDate.Should().Be(correctFromDateTime);
        toDate.Should().Be(correctToDateTime);
    }
}
