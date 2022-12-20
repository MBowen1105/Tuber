﻿namespace Tuber.Application.BankAccounts.Commands.BankAccountAdd;
public class BankAccountAddAPIRequest
{
    public string BankAccountName { get; set; } = "";
    public string UKBankAccount { get; set; } = "";
    public string UKSortCode { get; set; } = "";
    public Guid BankId { get; set; }
    public Guid? ImportTemplateId { get; set; }
    public int OrderBy { get; init; }
}
