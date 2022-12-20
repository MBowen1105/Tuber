using Tuber.Core.Common;

namespace Tuber.Application.Imports.Commands.ImportAdd;

public class ImportAddCommandResponse : CommandQueryResponseBase
{
    public ImportAddCommandResponse()
    {
        BankAccountId = Guid.Empty;
        ImportFileName = "";
        TotalImportRowCount = 0;
        ValidImportRowCount = 0;
        InvalidImportRowCount = 0;
    }

    public Guid BankAccountId { get; set; }
    public string ImportFileName { get; set; }
    public int TotalImportRowCount { get; set; }
    public int ValidImportRowCount { get; set; }
    public int InvalidImportRowCount { get; set; }
}
