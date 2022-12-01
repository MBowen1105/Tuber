using Tuber.Domain.Enums;

namespace Tuber.Domain.Dtos;
public class ImportDto
{
    public Guid ImportId { get; set; }
    public Guid BankAccountId { get; set; }
    public int ImportRowNumber { get; set; }
    public string? DateValue { get; set; }
    public string? DescriptionOnStatementValue { get; set; }
    public string? TransactionTypeValue { get; set; }
    public string? MoneyInValue { get; set; }
    public string? MoneyOutValue { get; set; }
    public string? BalanceOnStatementValue { get; set; }
    public string? SortCodeValue { get; set; }
    public string? AccountNumberValue { get; set; }
    public ImportRowStatus ImportRowStatus { get; set; }
    public string ImportRowStatusDesc { get; set; } = "";
    public string? ValidationFailureMessages { get; set; }
    public string? ImportedByUserFullName { get; set; }
    public DateTime ImportedUtc { get; set; }
}
