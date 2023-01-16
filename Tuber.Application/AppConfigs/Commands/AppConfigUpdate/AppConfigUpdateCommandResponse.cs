using Tuber.Core.Common;

namespace Tuber.Application.AppConfigs.Commands.AppConfigUpdate;

public class AppConfigUpdateCommandResponse : CommandQueryResponseBase
{
    public Guid AppConfigId { get; set; }

    public int CategorySuggestionHorizonDays{ get; init; }
}
