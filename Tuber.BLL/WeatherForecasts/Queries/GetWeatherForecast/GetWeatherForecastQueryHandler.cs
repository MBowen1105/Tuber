using MediatR;
using Tuber.Core.ValueObjects;
using Tuber.Domain.API.WeatherForecasts.Domains;
using Tuber.Domain.DAL;

namespace Tuber.BLL.WeatherForecasts.Queries.GetWeatherForecast
{
    public class GetWeatherForecastQueryHandler : IRequestHandler<GetWeatherForecastQueryRequest, GetWeatherForecastQueryResponse>
    {
        private readonly IRepo _weatherForecastRepo;

        public GetWeatherForecastQueryHandler(IRepo weatherForecastRepo)
        {
            _weatherForecastRepo = weatherForecastRepo;
        }

        public Task<GetWeatherForecastQueryResponse> Handle(GetWeatherForecastQueryRequest request, CancellationToken cancellationToken)
        {
            var forecast = _weatherForecastRepo.Get(request.FromDate, request.NumberOfDays);

            return Task.FromResult(new GetWeatherForecastQueryResponse
            {
                ForecastCount = request.NumberOfDays,
                Forecast = forecast
            });
        }
    }
}
