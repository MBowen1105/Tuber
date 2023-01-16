using MediatR;

namespace Tuber.Application.AppConfigs.Commands.AppConfigUpdate;
public class AppConfigUpdateCommandRequest : IRequest<AppConfigUpdateCommandResponse>
{
    public int CategorySuggestionHorizonDays{ get; init; }
}
