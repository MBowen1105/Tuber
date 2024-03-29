﻿using MediatR;

namespace Tuber.Application.Ledgers.Commands.LedgerAddDebit;
public class LedgerAddDebitCommandRequest : IRequest<LedgerAddDebitCommandResponse>
{
    public Guid InstitutionAccountId { get; set; }
    public DateTime DateUtc { get; set; }
    public string Description { get; set; } = "";
    public string? Reference { get; set; }
    public string TransactionType { get; set; } = "";
    public double MoneyOut { get; set; }
    public Guid CategoryId { get; set; }
    public Guid? SubcategoryId { get; set; }
}
