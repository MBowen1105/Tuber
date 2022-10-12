using Tuber.Core.ValueObjects;
using Tuber.Domain.API.WeatherForecasts.Domains;
using Tuber.Domain.DAL;

namespace Tuber.DAL;
public class WeatherForecastRepo : IRepo
{
    public WeatherForecastDomain[] Get(ISO8601Date fromDate, PositiveInt numberOfDays)
    {
        var summaries = new[]
            {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };

        return Enumerable.Range(1, numberOfDays.Value).Select(index =>
                new WeatherForecastDomain
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = Celcius.From(Random.Shared.Next(-20, 55)),
                    Summary = summaries[Random.Shared.Next(summaries.Length)]
                })
            .ToArray();
    }
}
