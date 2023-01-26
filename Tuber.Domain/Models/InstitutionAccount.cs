using Tuber.Application.Common;

namespace Tuber.Domain.Models;
public class InstitutionAccount : AuditableEntity
{
    public static readonly string FriendlyName = "Institution Account";

    //TODO: Remove constructor?
    //public InstitutionAccount()
    //{
        
    //    InstitutionAccountName = "";
    //    UKSortCode = "";
    //    UKInstitutionAccount = "";
    //    OpeningBalance = 0;
    //    OrderBy = int.MaxValue;
    //    InstitutionId = Guid.Empty;
    //    IsDeleted = false;
    //}

    public Guid InstitutionAccountId { get; set; } = Guid.Empty;
    public string InstitutionAccountName { get; set; } = string.Empty;
    public string UKSortCode { get; set; } = string.Empty;
    public string UKInstitutionAccount { get; set; } = string.Empty;
    public int OrderBy { get; set; } = int.MaxValue;
    public Guid InstitutionId { get; set; } = Guid.Empty;
    public Guid? ImportTemplateId { get; set; } = Guid.Empty;
    public double OpeningBalance { get; set; } = 0.00;
    public bool IsDeleted { get; set; } = false;
    public virtual Institution? Institution { get; set; }
    public virtual ImportTemplate? ImportTemplate { get; set; }   
}
