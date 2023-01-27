namespace Tuber.Application.InstitutionAccounts.Commands.InstitutionAccountUpdate;
public class InstitutionAccountUpdateAPIRequest
{
    public Guid InstitutionAccountId { get; init; }
    public string InstitutionAccountName { get; init; } = "";
    public string? UKSortCode { get; set; }
    public string? UKInstitutionAccount { get; set; }
    public int OrderBy { get; set; }
    public Guid InstitutionId { get; set; }
    public Guid? ImportTemplateId { get; set; }
    public double OpeningBalance { get; set; }
}
