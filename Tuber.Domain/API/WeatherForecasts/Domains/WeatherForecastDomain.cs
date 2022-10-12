using Tuber.Core.ValueObjects;

namespace Tuber.Domain.API.WeatherForecasts.Domains;
public class WeatherForecastDomain
{
    public DateTime Date { get; set; }
    public Celcius TemperatureC { get; set; } = Celcius.From(0);
    public string? Summary { get; set;}
    public int TemperatureF => 32 + (int)(TemperatureC.Value / 0.5556);
}
