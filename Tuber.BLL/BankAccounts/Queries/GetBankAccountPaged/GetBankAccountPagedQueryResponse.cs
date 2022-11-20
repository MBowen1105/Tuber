﻿using Tuber.Core.Common;
using Tuber.Domain.Dtos;

namespace Tuber.BLL.BankAccounts.Queries.GetBankAccountPaged;
public class GetBankAccountPagedQueryResponse : PagedQueryResponseBase
{
    public int BankAccountCount { get; init; } = 0;
    public List<BankAccountDto> BankAccounts { get; init; } = new();
}