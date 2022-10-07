using Tuber.Domain.API.WeatherForecasts.Domains;

namespace Tuber.Domain.API.WeatherForecasts.GetWeatherForecast;
public class GetWeatherForecastAPIResponse
{
    public int ForecastCount { get; init; }
    public WeatherForecastDomain[] Forecast { get; init; } = Array.Empty<WeatherForecastDomain>();
}
