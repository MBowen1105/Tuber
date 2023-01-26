namespace Tuber.Domain.Dtos;
public class InstitutionAccountGetPaged_InstitutionAccount
{
    public Guid InstitutionAccountId { get; set; }
    public string? InstitutionAccountName { get; set; } = "";
    public int OrderBy { get; set; } = 0;
    public string UKSortCode { get; set; } = "";
    public string UKInstitutionAccount { get; set; } = "";
    public string CreatedByUserFullName { get; set; } = "";
    public DateTime CreatedOnUtc { get; set; }
    public string? UpdatedByUserFullName { get; set; }
    public DateTime? UpdatedOnUtc { get; set; }
}
