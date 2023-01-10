using Tuber.Application.Enums;

namespace Tuber.Application.Dtos;
public class GetImportByBankAccountId_Import
{
    public Guid ImportId { get; set; }
    public Guid BankAccountId { get; set; }
    public string BankAccountBankAccountName { get; init; } = "";
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
    public Guid? CategorySubcategoryId { get; set; }
    public ImportRowStatus ImportRowStatus { get; set; }
    public string ImportRowStatusDesc { get; set; } = "";
    public string? ValidationFailureMessages { get; set; }
    public string? ImportedByUserFullName { get; set; }
    public DateTime ImportedUtc { get; set; }
}
