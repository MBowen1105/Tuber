namespace Tuber.Application.Imports.Commands.ImportAdd;
public class ImportAddAPIResponse
{
    public Guid BankAccountId { get; init; }
    public string ImportFileName { get; init; } = "";
    public int TotalImportRowCount { get; init; }
    public int ValidImportRowCount { get; init; }
    public int InvalidImportRowCount { get; init; }
}
