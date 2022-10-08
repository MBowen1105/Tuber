using MediatR;
using Microsoft.Extensions.Configuration;
using Tuber.Core.ValueObjects;
using Tuber.Domain.API.WeatherForecasts.Domains;

namespace Tuber.BLL.WeatherForecasts.Queries.GetWeatherForecast
{
    public class GetWeatherForecastQueryHandler : IRequestHandler<GetWeatherForecastQueryRequest, GetWeatherForecastQueryResponse>
    {
        private readonly bool _isStubbed;

        public GetWeatherForecastQueryHandler(IConfiguration config)
        {
            bool.TryParse(config["IsStubbed"], out _isStubbed);
        }

        public Task<GetWeatherForecastQueryResponse> Handle(GetWeatherForecastQueryRequest request, CancellationToken cancellationToken)
        {
            if (_isStubbed) return GetWeatherForecastQueryStub.Stub(request);

            return Task.FromResult(new GetWeatherForecastQueryResponse
            {
                ForecastCount = PositiveInt.From(0),
                Forecast = Array.Empty<WeatherForecastDomain>()
            });
        }
    }
}
