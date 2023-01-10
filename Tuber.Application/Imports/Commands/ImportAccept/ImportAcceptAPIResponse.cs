using Tuber.Core.Common;

namespace Tuber.Application.Imports.Commands.ImportAccept;
public class ImportAcceptAPIResponse : CommandQueryResponseBase
{
    public Guid BankAccountId { get; init; }
    public int TotalAcceptedRowCount { get; set; }
}
