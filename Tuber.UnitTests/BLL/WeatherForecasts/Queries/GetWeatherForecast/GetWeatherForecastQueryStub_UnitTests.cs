using FluentAssertions;
using Tuber.BLL.WeatherForecasts.Queries.GetWeatherForecast;

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
    public async Task Test1(int numOfDays)
    {
        var request = new GetWeatherForecastQueryRequest
        {
            FromDate = "20220101",
            NumberOfDays = numOfDays
        };

        var result = await GetWeatherForecastQueryStub.Stub(request);

        result.ForecastCount.Should().Be(numOfDays);
        result.Forecast.Length.Should().Be(numOfDays);

        Assert.Pass();
    }
}