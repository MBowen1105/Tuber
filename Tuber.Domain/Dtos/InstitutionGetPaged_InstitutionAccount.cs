namespace Tuber.Domain.Dtos;
public class InstitutionGetPaged_InstitutionAccount
{
    public Guid InstitutionAccountId { get; set; }
    public string? InstitutionAccountName { get; set; } = "";
    public int OrderBy { get; set; } = 0;
    public string UKSortCode { get; set; } = "";
    public string UKInstitutionAccount { get; set; } = "";
}
