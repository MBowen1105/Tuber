using MediatR;

namespace Tuber.Application.Ledgers.Commands.LedgerAddCredit;
public class LedgerAddCreditCommandRequest : IRequest<LedgerAddCreditCommandResponse>
{
    public Guid BankAccountId { get; set; }
    public DateTime DateUtc { get; set; }
    public string Description { get; set; } = "";
    public string? Reference { get; set; }
    public string TransactionType { get; set; } = "";
    public double? MoneyIn { get; set; }
    public Guid CategoryId { get; set; }
    public Guid? SubcategoryId { get; set; }
}
