﻿namespace Tuber.Application.Ledgers.Commands.LedgerAddTransferOut;
public class LedgerAddTransferOutAPIRequest
{
    public Guid InstitutionAccountId { get; set; }
    public DateTime DateUtc { get; set; }
    public string Description { get; set; } = "";
    public string? Reference { get; set; }
    public double MoneyOut { get; set; }
    public Guid CategoryId { get; set; }
    public Guid? SubcategoryId { get; set; }
    public Guid TransferInstitutionAccountId { get; set; }
}
