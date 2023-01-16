namespace Tuber.Application.AppConfigs.Commands.AppConfigUpdate;
public class AppConfigUpdateAPIResponse
{
    public Guid AppConfigId { get; set; }
    public int CategorySuggestionHorizonDays { get; init; }
}
