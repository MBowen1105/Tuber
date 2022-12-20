using Tuber.Core.Common;

namespace Tuber.Application.BankAccounts.Queries.BankAccountGetById;
public class BankAccountGetByIdQueryResponse : CommandQueryResponseBase
{
    public Guid BankAccountId { get; init; }
    public Guid BankId { get; init; }
    public string BankAccountName { get; init; } = "";
    public string UKSortCode { get; init; } = "";
    public string UKBankAccount { get; init; } = "";
    public int OrderBy { get; init; }
    public string CreatedByUserFullName { get; init; } = "";
    public DateTime CreatedOnUtc { get; init; }
    public string? UpdatedByUserFullName { get; init; } = "";
    public DateTime? UpdatedOnUtc { get; init; }
}
