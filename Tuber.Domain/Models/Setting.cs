using Tuber.Application.Common;

namespace Tuber.Domain.Models;
public class Setting : AuditableEntity
{
    public int CategorySuggestionHorizonDays { get; init; }
}
