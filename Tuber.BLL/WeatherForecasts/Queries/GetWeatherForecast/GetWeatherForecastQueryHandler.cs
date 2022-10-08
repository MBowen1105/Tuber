using MediatR;
using Tuber.Core.ValueObjects;
using Tuber.Domain.API.WeatherForecasts.Domains;

namespace Tuber.BLL.WeatherForecasts.Queries.GetWeatherForecast
{
    public class GetWeatherForecastQueryHandler : IRequestHandler<GetWeatherForecastQueryRequest, GetWeatherForecastQueryResponse>
    {
        public Task<GetWeatherForecastQueryResponse> Handle(GetWeatherForecastQueryRequest request, CancellationToken cancellationToken)
        {
            if (request.IsStubbed) return Stub(request);

            return Task.FromResult(new GetWeatherForecastQueryResponse
            {
                ForecastCount = PositiveInt.From(0),
                Forecast = Array.Empty<WeatherForecastDomain>()
            });
        }

        public static Task<GetWeatherForecastQueryResponse> Stub(GetWeatherForecastQueryRequest request)
        {
            var summaries = new[]
            {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };

            var forecast = Enumerable.Range(1, request.NumberOfDays.Value).Select(index =>
               new WeatherForecastDomain
               {
                   Date = DateTime.Now.AddDays(index),
                   TemperatureC = Celcius.From(Random.Shared.Next(-20, 55)),
                   Summary = summaries[Random.Shared.Next(summaries.Length)]
               })
            .ToArray();

            return Task.FromResult(new GetWeatherForecastQueryResponse
            {
                ForecastCount = request.NumberOfDays,
                Forecast = forecast,
            });
        }
    }
}
