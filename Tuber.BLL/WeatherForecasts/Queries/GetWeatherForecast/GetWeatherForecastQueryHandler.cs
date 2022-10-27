using MediatR;
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
            return Task.FromResult(new GetWeatherForecastQueryResponse
            {
                ForecastCount = request.NumberOfDays,
                Forecast = _weatherForecastRepo.Get(request.FromDate, request.NumberOfDays)
            });
        }
    }
}
