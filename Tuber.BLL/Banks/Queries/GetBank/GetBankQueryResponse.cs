﻿using Tuber.Core.ValueObjects;
using Tuber.Domain.API.Banks.Domains;

namespace Tuber.BLL.Banks.Queries.GetBank;
public class GetBankQueryResponse : QueryResponseBase
{
    public PositiveInt? BankCount { get; init; }
    public BankDomain[]? Bank { get; init; }
}
