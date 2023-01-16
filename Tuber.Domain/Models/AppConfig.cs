using Tuber.Application.Common;

namespace Tuber.Domain.Models;
public class AppConfig : AuditableEntity
{
    public static readonly string FriendlyName = "AppConfig";

    public Guid AppConfigId { get; init; } = Guid.Empty;
    public int CategorySuggestionHorizonDays { get; set; } = 365;
}
