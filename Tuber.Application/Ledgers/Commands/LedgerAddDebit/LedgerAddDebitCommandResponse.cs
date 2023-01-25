using Tuber.Core.Common;

namespace Tuber.Application.Ledgers.Commands.LedgerAddDebit;
public class LedgerAddDebitCommandResponse : CommandQueryResponseBase
{
    public Guid LedgerId { get; init; }
}
