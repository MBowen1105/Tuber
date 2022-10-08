using MediatR;
using Tuber.Core.ValueObjects;

namespace Tuber.BLL.WeatherForecasts.Queries.GetWeatherForecast;
public class GetWeatherForecastQueryRequest : IRequest<GetWeatherForecastQueryResponse>
{
    public ISO8601Date FromDate { get; set; }
    public PositiveInt NumberOfDays { get; set; }
}
