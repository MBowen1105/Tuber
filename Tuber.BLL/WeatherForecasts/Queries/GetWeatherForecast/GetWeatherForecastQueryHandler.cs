using MediatR;
using Tuber.Core.ValueObjects;
using Tuber.Domain.API.WeatherForecasts.Domains;

namespace Tuber.BLL.WeatherForecasts.Queries.GetWeatherForecast
{
    public class GetWeatherForecastQueryHandler : IRequestHandler<GetWeatherForecastQueryRequest, GetWeatherForecastQueryResponse>
    {
        public Task<GetWeatherForecastQueryResponse> Handle(GetWeatherForecastQueryRequest request, CancellationToken cancellationToken)
        {
            var summaries = new[]
            {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };

            return Task.FromResult(new GetWeatherForecastQueryResponse
            {
                ForecastCount = request.NumberOfDays,
                Forecast = Enumerable.Range(1, request.NumberOfDays.Value).Select(index =>
               new WeatherForecastDomain
               {
                   Date = DateTime.Now.AddDays(index),
                   TemperatureC = Celcius.From(Random.Shared.Next(-20, 55)),
                   Summary = summaries[Random.Shared.Next(summaries.Length)]
               })
            .ToArray()
            });
        }
    }
}
