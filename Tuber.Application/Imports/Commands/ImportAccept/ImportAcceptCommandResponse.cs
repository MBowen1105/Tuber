using Tuber.Core.Common;

namespace Tuber.Application.Imports.Commands.ImportAccept;
public class ImportAcceptCommandResponse : CommandQueryResponseBase
{
    public Guid BankAccountId { get; init; }
    public int TotalAcceptedRowCount { get; init; } = 0;
    public int TotalCreatedRowCount { get; init; } = 0;
    public int TotalUpdatedRowCount { get; init; } = 0;
    public int TotalAlreadyReconciledCount { get; init; } = 0;

}
