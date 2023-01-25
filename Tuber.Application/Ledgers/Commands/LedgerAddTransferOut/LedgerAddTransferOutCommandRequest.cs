using MediatR;

namespace Tuber.Application.Ledgers.Commands.LedgerAddTransferOut;
public class LedgerAddTransferOutCommandRequest : IRequest<LedgerAddTransferOutCommandResponse>
{
    public Guid BankAccountId { get; set; }
    public DateTime DateUtc { get; set; }
    public string Description { get; set; } = "";
    public string? Reference { get; set; }
    public double MoneyOut { get; set; }
    public Guid CategoryId { get; set; }
    public Guid? SubcategoryId { get; set; }
    public Guid TransferBankAccountId { get; set; }
}
