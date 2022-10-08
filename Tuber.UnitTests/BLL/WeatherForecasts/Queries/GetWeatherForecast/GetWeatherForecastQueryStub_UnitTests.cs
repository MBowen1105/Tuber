using FluentAssertions;
using Tuber.BLL.WeatherForecasts.Queries.GetWeatherForecast;
using Tuber.Core.ValueObjects;

namespace Tuber.UnitTests.BLL.WeatherForecasts.Queries.GetWeatherForecast;

public class GetWeatherForecastQueryStub_UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase(0)]
    [TestCase(1)]
    [TestCase(10)]
    public async Task Stub_ReturnsCorrectNumberOfForecastDays(int numOfDays)
    {
        var request = new GetWeatherForecastQueryRequest
        {
            FromDate = ISO8601Date.From("20220101"),
            NumberOfDays = PositiveInt.From(numOfDays)
        };

        var result = await GetWeatherForecastQueryStub.Stub(request);

        result.ForecastCount.Should().Be(numOfDays);
        result.Forecast.Length.Should().Be(numOfDays);
    }
}