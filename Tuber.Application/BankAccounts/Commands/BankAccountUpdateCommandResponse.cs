﻿using Tuber.Core.Common;

namespace Tuber.Application.BankAccounts.Commands.BankAccountUpdate;

public class BankAccountUpdateCommandResponse : CommandQueryResponseBase
{
    public Guid BankAccountId { get; init; }
    public string BankAccountName { get; init; } = "";
    public string? UKSortCode { get; set; }
    public string? UKBankAccountAccount { get; set; }
    public int OrderBy { get; set; }
    public Guid BankId { get; set; }
    public Guid? ImportTemplateId { get; set; }
}