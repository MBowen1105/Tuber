using Tuber.Core.Common;

namespace Tuber.Application.Institutions.Commands.InstitutionUpdate;

public class InstitutionUpdateCommandResponse : CommandQueryResponseBase
{
    public Guid InstitutionId { get; init; }
    public string InstitutionName { get; init; } = "";
    public int OrderBy { get; init; }
}
