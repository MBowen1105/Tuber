namespace Tuber.BLL.Imports.Commands.AddImport;
public class AddImportAPIResponse
{
    public Guid BankAccountId { get; init; }
    public string ImportFileName { get; init; } = "";
    public int ValidImportRowCount { get; init; }
    public int InvalidImportRowCount { get; init; }
}
