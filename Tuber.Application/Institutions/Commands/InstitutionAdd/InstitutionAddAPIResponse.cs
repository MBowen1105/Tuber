namespace Tuber.Application.Institutions.Commands.InstitutionAdd;
public class InstitutionAddAPIResponse
{
    public Guid InstitutionId { get; init; }
    public string InstitutionName { get; set; } = "";
    public int OrderBy { get; init; }
}
