using Tuber.Application.Enums;

namespace Tuber.Domain.Dtos;
public class GetImportByInstitutionAccountId_Import
{
    public Guid ImportId { get; set; }
    public Guid InstitutionAccountId { get; set; }
    public string InstitutionAccountInstitutionAccountName { get; init; } = "";
    public int ImportRowNumber { get; set; }
    public string? DateValueISO8601 { get; set; }
    public string? DescriptionOnStatementValue { get; set; }
    public string? DescriptionValue { get; set; }
    public string? ReferenceOnStatementValue { get; set; }
    public string? TransactionTypeValue { get; set; }
    public string? MoneyInValue { get; set; }
    public string? MoneyOutValue { get; set; }
    public string? BalanceOnStatementValue { get; set; }
    public string? SortCodeValue { get; set; }
    public string? AccountNumberValue { get; set; }
    public Guid? CategoryId { get; set; }
    public string? CategoryCategoryName { get; set; }
    public Guid? SubcategoryId { get; set; }
    public string? SubcategorySubcategoryName { get; set; }
    public ImportRowStatus ImportRowStatus { get; set; }
    public string ImportRowStatusDesc { get; set; } = "";
    public string? ValidationFailureMessages { get; set; }
    public string? ImportedByUserFullName { get; set; }
    public DateTime ImportedUtc { get; set; }
}
