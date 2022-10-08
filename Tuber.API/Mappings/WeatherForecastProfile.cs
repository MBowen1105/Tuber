using AutoMapper;
using Tuber.BLL.WeatherForecasts.Queries.GetWeatherForecast;
using Tuber.Core.ValueObjects;
using Tuber.Domain.API.WeatherForecasts.GetWeatherForecast;

namespace Tuber.API.Mappings;

public class WeatherForecastProfile : Profile
{
    public WeatherForecastProfile()
    {
        CreateMap<GetWeatherForecastAPIRequest, GetWeatherForecastQueryRequest>()
             .ForMember(dest => dest.FromDate, opt => opt.MapFrom(src => ISO8601Date.From(src.FromDate)))
             .ForMember(dest => dest.NumberOfDays, opt => opt.MapFrom(src => PositiveInt.From(src.NumberOfDays)));

        CreateMap<GetWeatherForecastQueryResponse, GetWeatherForecastAPIResponse>()
             .ForMember(dest => dest.ForecastCount, opt => opt.MapFrom(src => PositiveInt.From((int)src.ForecastCount)));
    }
}
