using Tuber.Core.Common;

namespace Tuber.Application.Ledgers.Commands.LedgerAddCredit;
public class LedgerAddCreditCommandResponse : CommandQueryResponseBase
{
    public Guid LedgerId { get; init; }
}
