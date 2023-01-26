using Tuber.Core.Common;

namespace Tuber.Application.Imports.Commands.ImportAdd;

public class ImportAddCommandResponse : CommandQueryResponseBase
{
    public ImportAddCommandResponse()
    {
        InstitutionAccountId = Guid.Empty;
        ImportFileName = "";
        TotalImportRowCount = 0;
        CategorisedRowCount = 0;
        UncategorisedRowCount = 0;
        ValidImportRowCount = 0;
        InvalidImportRowCount = 0;
    }

    public Guid InstitutionAccountId { get; set; }
    public string ImportFileName { get; set; }
    public int TotalImportRowCount { get; set; }
    public int CategorisedRowCount { get; init; }
    public int UncategorisedRowCount { get; init; }
    public int ValidImportRowCount { get; set; }
    public int InvalidImportRowCount { get; set; }
}
