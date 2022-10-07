using AutoMapper;
using Tuber.BLL.WeatherForecasts.Queries.GetWeatherForecast;
using Tuber.Domain.API.WeatherForecasts.GetWeatherForecast;

namespace Tuber.API.Mappings;

public class WeatherForecastProfile : Profile
{
	public WeatherForecastProfile()
	{
		CreateMap<GetWeatherForecastAPIRequest, GetWeatherForecastQueryRequest>();
		CreateMap<GetWeatherForecastQueryResponse, GetWeatherForecastAPIResponse>();
    }
}
