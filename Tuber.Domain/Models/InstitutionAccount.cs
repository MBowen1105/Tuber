using Tuber.Application.Common;

namespace Tuber.Domain.Models;
public class InstitutionAccount : AuditableEntity
{
    public static readonly string FriendlyName = "Institution Account";

    //TODO: Remove constructor?
    public InstitutionAccount()
    {
        InstitutionAccountId = Guid.Empty;
        InstitutionAccountName = "";
        UKSortCode = "";
        UKInstitutionAccount = "";
        OpeningBalance = 0;
        OrderBy = int.MaxValue;
        InstitutionId = Guid.Empty;
        IsDeleted = false;
    }

    public Guid InstitutionAccountId { get; set; }
    public string InstitutionAccountName { get; set; }
    public string UKSortCode { get; set; }
    public string UKInstitutionAccount { get; set; }
    public int OrderBy { get; set; }
    public Guid InstitutionId { get; set; }
    public Guid? ImportTemplateId { get; set; }
    public double OpeningBalance { get; set; }
    public bool IsDeleted { get; set; }
    public virtual Institution? Institution { get; set; }
    public virtual ImportTemplate? ImportTemplate { get; set; }   
}
