﻿using Tuber.Core.Common;
using Tuber.Application.Dtos;

namespace Tuber.Application.Banks.Queries.BankGetById;
public class BankGetByIdQueryResponse : CommandQueryResponseBase
{
    public Guid BankId { get; init; }
    public string BankName { get; init; } = "";
    public int OrderBy { get; init; }
    public Guid? ImportTemplateId { get; init; }
    public BankGetById_ImportTemplate? ImportTemplate { get; init; }
    public List<BankGetById_BankAccount> BankAccounts { get; init; } = new();
}