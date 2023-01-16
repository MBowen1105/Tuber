using Tuber.Core.Common;

namespace Tuber.Application.AppConfigs.Queries.AppConfigGet;
public class AppConfigGetQueryResponse : CommandQueryResponseBase
{
    public Guid AppConfigId { get; init; }
    public int CategorySuggestionHorizonDays { get; init; }
}