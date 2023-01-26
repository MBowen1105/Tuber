using Tuber.Core.Common;

namespace Tuber.Application.Institutions.Commands.InstitutionAdd;

public class InstitutionAddCommandResponse : CommandQueryResponseBase
{
    public Guid InstitutionId { get; init; }
    public string InstitutionName { get; init; } = "";
    public int OrderBy { get; init; }
}
