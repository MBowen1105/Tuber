using MediatR;
using Tuber.Core.ValueObjects;

namespace Tuber.BLL.WeatherForecasts.Queries.GetWeatherForecast;
public class GetWeatherForecastQueryRequest : IRequest<GetWeatherForecastQueryResponse>
{
    public ISO8601Date FromDate { get; set; } = string.Empty;
    public PositiveInt NumberOfDays { get; set; } = PositiveInt.From(1);
}
