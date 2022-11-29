using Tuber.Core.Common;

namespace Tuber.BLL.Imports.Commands.AddImport;

public class AddImportCommandResponse : CommandQueryResponseBase
{
    public AddImportCommandResponse()
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
