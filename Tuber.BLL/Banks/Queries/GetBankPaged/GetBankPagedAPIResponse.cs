﻿using Tuber.Domain.API.Common;
using Tuber.Domain.Dtos;

namespace Tuber.BLL.Banks.Queries.GetBankPaged;
public class GetBankPagedAPIResponse : PagedAPIResponse
{
    public int BankCount { get; init; }
    public List<GetBankPaged_Bank> Banks { get; init; } = new();
}
