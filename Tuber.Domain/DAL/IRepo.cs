using Tuber.Core.ValueObjects;
using Tuber.Domain.API.WeatherForecasts.Domains;

namespace Tuber.Domain.DAL;
public interface IRepo
{
    WeatherForecastDomain[] Get(ISO8601Date fromDate, PositiveInt numberOfDays);
}
