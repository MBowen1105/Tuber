using Tuber.Domain.Dtos;

namespace Tuber.Domain.Dtos;
public class InstitutionGetPaged_Institution
{
    public Guid InstitutionId { get; init; }
    public string InstitutionName { get; init; } = "";
    public int OrderBy { get; init; } = 0;
    public List<InstitutionGetPaged_InstitutionAccount> InstitutionAccounts { get; set; } = new();
    public string CreatedByUserFullName { get; init; } = "";
    public DateTime CreatedOnUtc { get; init; }
    public string? UpdatedByUserFullName { get; init; }
    public DateTime UpdatedOnUtc { get; init; }
}
