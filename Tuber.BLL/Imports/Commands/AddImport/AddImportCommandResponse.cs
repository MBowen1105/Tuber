using Tuber.Core.Common;

namespace Tuber.BLL.Imports.Commands.AddImport;

public class AddImportCommandResponse : CommandQueryResponseBase
{
    public Guid ImportId { get; set; }
    public Guid BankAccountId { get; set; }    
    public string ImportFileName { get; set; }
    public int ValidImportRowCount { get; set; }
    public int InvalidImportRowCount { get; set; }
}
