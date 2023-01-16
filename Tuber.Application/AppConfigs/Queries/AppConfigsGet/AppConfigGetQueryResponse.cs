using Tuber.Core.Common;

namespace Tuber.Application.AppConfigs.Queries.AppConfigGet;
public class AppConfigGetQueryResponse : CommandQueryResponseBase
{
    public int CategorySuggestionHorizonDays { get; init; }
}