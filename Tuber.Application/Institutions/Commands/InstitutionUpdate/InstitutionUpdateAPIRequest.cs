namespace Tuber.Application.Institutions.Commands.InstitutionUpdate;
public class InstitutionUpdateAPIRequest
{
    public Guid InstitutionId { get; init; }
    public string InstitutionName { get; init; } = "";
    public int OrderBy { get; init; }
}
