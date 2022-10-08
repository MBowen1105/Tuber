using FluentAssertions;
using Tuber.Core.Exceptions;
using Tuber.Core.ValueObjects;

namespace Tuber.UnitTests.BLL.WeatherForecasts.Queries.GetWeatherForecast;

public class ISO8601Date_UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase("")]
    [TestCase("2022010")]
    [TestCase("202201011")]
    [TestCase("202201DD")]
    public void ISO8601Date_RejectsInvalidLengthAndType(string invalidValue)
    {
            Assert.Throws<InvalidISO8601DateFormatException>(()=> ISO8601Date.From(invalidValue));
    }

    [Test]
    [TestCase("20220132")]
    [TestCase("20220100")]
    [TestCase("20220001")]
    [TestCase("20221301")]
    [TestCase("20220229")]

    public void ISO8601Date_RejectsInvalidDates(string invalidValue)
    {
        Assert.Throws<InvalidISO8601DateValueException>(() => ISO8601Date.From(invalidValue));
    }
}