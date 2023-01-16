using MediatR;
using Tuber.Application.Common.Interfaces;

namespace Tuber.Application.AppConfigs.Commands.AppConfigUpdate;

public class AppConfigUpdateCommandHandler : IRequestHandler<AppConfigUpdateCommandRequest, AppConfigUpdateCommandResponse>
{
    private readonly IAppConfigUpdaterService _AppConfigUpdaterService;

    public AppConfigUpdateCommandHandler(IAppConfigUpdaterService AppConfigUpdaterService)
    {
        _AppConfigUpdaterService = AppConfigUpdaterService;
    }

    public Task<AppConfigUpdateCommandResponse> Handle(AppConfigUpdateCommandRequest request, CancellationToken cancellationToken)
    {
        var serviceResult = _AppConfigUpdaterService.Update(request.CategorySuggestionHorizonDays);

        return Task.FromResult(new AppConfigUpdateCommandResponse
        {
            AppConfigId = serviceResult.Payload.AppConfigId,
            CategorySuggestionHorizonDays = serviceResult.Payload.CategorySuggestionHorizonDays,
            Exceptions = serviceResult.Exceptions,
        });
    }
}

