using AutoMapper;
using Tuber.BLL.WeatherForecasts.Queries.GetWeatherForecast;
using Tuber.Core.ValueObjects;
using Tuber.Domain.API.WeatherForecasts.GetWeatherForecast;

namespace Tuber.API.Mappings;

public class WeatherForecastProfile : Profile
{
    private readonly bool _isStubbed = true;

    public WeatherForecastProfile()
    {
   
        //  Has to go from a (string date) "YYYYMMDD" in the API request to an (ISO8601) FromDate in the
        //  Query Request. Also from an (int) NumberOfDays in the API request, to an (PositiveInt) NumberOfDays
        //  in the Query Request.
        CreateMap<GetWeatherForecastAPIRequest, GetWeatherForecastQueryRequest>()
             .ForMember(dest => dest.FromDate, opt => opt.MapFrom(src => ISO8601Date.From(src.FromDate)))
             .ForMember(dest => dest.NumberOfDays, opt => opt.MapFrom(src => PositiveInt.From(src.NumberOfDays)))
             .ForMember(dest => dest.IsStubbed, opt => opt.MapFrom(x => _isStubbed));

        CreateMap<GetWeatherForecastQueryResponse, GetWeatherForecastAPIResponse>()
             .ForMember(dest => dest.ForecastCount, opt => opt.MapFrom(src => PositiveInt.From((int)src.ForecastCount)));
    }
}
