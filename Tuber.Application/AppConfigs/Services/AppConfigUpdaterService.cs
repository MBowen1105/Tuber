using Tuber.Application.Common;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Exceptions;
using Tuber.Domain.Models;

namespace Tuber.Application.AppConfigs.Services;
public class AppConfigUpdaterService : IAppConfigUpdaterService
{
    private readonly IAppConfigRepository _AppConfigRepo;

    public AppConfigUpdaterService(IAppConfigRepository AppConfigRepo)
    {
        _AppConfigRepo = AppConfigRepo;
    }

    public ServiceResult<AppConfig> Update(int categorysuggestionHorizonDays)
    {
        var appConfig = _AppConfigRepo.Update(categorysuggestionHorizonDays);

        if (appConfig.AppConfigId == Guid.Empty)
            return new ServiceResult<AppConfig>(
                payload: appConfig,
                exception: new EntityDoesNotExistException(AppConfig.FriendlyName, appConfig.AppConfigId));

        _AppConfigRepo.SaveChanges();

        return new ServiceResult<AppConfig>(payload: appConfig);
    }
}
