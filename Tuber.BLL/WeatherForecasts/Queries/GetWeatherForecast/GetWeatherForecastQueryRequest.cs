using MediatR;

namespace Tuber.BLL.WeatherForecasts.Queries.GetWeatherForecast;
public class GetWeatherForecastQueryRequest : IRequest<GetWeatherForecastQueryResponse>
{
    public string? FromDate { get; set; }
    public int NumberOfDays { get; set; }
}
