using Tuber.Domain.Dtos;

namespace Tuber.Application.Imports.Queries.ImportGetByInstitutionAccountId;
public class ImportGetByInstitutionAccountIdAPIResponse
{
    public int TotalImportRowCount { get; set; }
    public int ValidImportRowCount { get; set; }
    public int InvalidImportRowCount { get; set; }
    public IEnumerable<GetImportByInstitutionAccountId_Import> Imports { get; init; } = new List<GetImportByInstitutionAccountId_Import>();
}
