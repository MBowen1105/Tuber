using Tuber.Core.Common;

namespace Tuber.Application.Ledgers.Commands.LedgerAddTransferOut;
public class LedgerAddTransferOutCommandResponse : CommandQueryResponseBase
{
    public Guid LedgerId { get; init; }
}
