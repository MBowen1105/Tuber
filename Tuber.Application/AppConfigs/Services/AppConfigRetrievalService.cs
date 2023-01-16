using Tuber.Application.Common;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Exceptions;
using Tuber.Domain.Models;

namespace Tuber.Application.AppConfigs.Services;
public class AppConfigRetrievalService : IAppConfigRetrievalService
{
    private readonly IAppConfigRepository _appConfigRepo;

    public AppConfigRetrievalService(IAppConfigRepository appConfigRepo)
    {
        _appConfigRepo = appConfigRepo;
    }

    public ServiceResult<AppConfig> Get()
    {
        var appConfig = _appConfigRepo.Get();

        if (appConfig.AppConfigId == Guid.Empty)
            return new ServiceResult<AppConfig>(
                payload: appConfig,
                exception: new EntityDoesNotExistException(AppConfig.FriendlyName, Guid.Empty));

        return new ServiceResult<AppConfig>(appConfig);
    }
}
