using AutoMapper;
using Tuber.Application.AppConfigs.Commands.AppConfigUpdate;
using Tuber.Application.AppConfigs.Queries.AppConfigGet;
using Tuber.Domain.Models;

namespace Tuber.Application.AppConfigs;
public class AppConfigProfile : Profile
{
    public AppConfigProfile()
    {
        //  AppConfigGet
        CreateMap<AppConfigGetQueryResponse, AppConfigGetAPIResponse>();
        CreateMap<AppConfig, AppConfigGetQueryResponse>()
            .ForMember(dest => dest.Exceptions, opt=>opt.Ignore());

        //  AppConfigUpdate
        CreateMap<AppConfigUpdateAPIRequest, AppConfigUpdateCommandRequest>();
        CreateMap<AppConfigUpdateCommandResponse, AppConfigUpdateAPIResponse>();
    }
}
