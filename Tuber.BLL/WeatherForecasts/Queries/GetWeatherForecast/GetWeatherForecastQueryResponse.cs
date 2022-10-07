using Tuber.Domain.API.WeatherForecasts.Domains;

namespace Tuber.BLL.WeatherForecasts.Queries.GetWeatherForecast;
public class GetWeatherForecastQueryResponse
{
    public int ForecastCount { get; init; } = 0;
    public WeatherForecastDomain[] Forecast { get; init; } = Array.Empty<WeatherForecastDomain>();
}
