using MediatR;
using Tuber.Domain.API.WeatherForecasts.Domains;

namespace Tuber.BLL.WeatherForecasts.Queries.GetWeatherForecast
{
    public class GetWeatherForecastQueryHandler : IRequestHandler<GetWeatherForecastQueryRequest, GetWeatherForecastQueryResponse>
    {
        private readonly bool _isStubbed = true;

        public Task<GetWeatherForecastQueryResponse> Handle(GetWeatherForecastQueryRequest request, CancellationToken cancellationToken)
        {
            if (_isStubbed) return GetWeatherForecastQueryStub.Stub(request);

            return Task.FromResult(new GetWeatherForecastQueryResponse
            {
                ForecastCount = request.NumberOfDays,
                Forecast = Array.Empty<WeatherForecastDomain>()
            });
        }

        
    }
}
