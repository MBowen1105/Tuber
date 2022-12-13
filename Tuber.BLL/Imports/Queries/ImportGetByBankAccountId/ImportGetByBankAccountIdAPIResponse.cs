using Tuber.Domain.Dtos;

namespace Tuber.BLL.Imports.Queries.ImportGetByBankAccountId;
public class ImportGetByBankAccountIdAPIResponse
{
    public int TotalImportRowCount { get; set; }
    public int ValidImportRowCount { get; set; }
    public int InvalidImportRowCount { get; set; }
    public IEnumerable<GetImportByBankAccountId_Import> Imports { get; init; } = new List<GetImportByBankAccountId_Import>();
}
