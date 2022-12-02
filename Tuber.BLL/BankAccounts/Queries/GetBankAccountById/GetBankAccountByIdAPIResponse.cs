﻿namespace Tuber.BLL.BankAccounts.Queries.GetBankAccountById;
public class GetBankAccountByIdAPIResponse
{
    public Guid BankAccountId { get; init; }
    public Guid BankId { get; init; }
    public string Name { get; init; } = "";
    public string UKBankAccount { get; init; } = "";
    public string UKSortCode { get; init; } = "";
    public int OrderBy { get; init; }
    public string CreatedByUserFullName { get; init; } = "";
    public DateTime CreatedOnUtc { get; init; }
    public string? UpdatedByUserFullName { get; init; } = "";
    public DateTime? UpdatedOnUtc { get; init; }
}
