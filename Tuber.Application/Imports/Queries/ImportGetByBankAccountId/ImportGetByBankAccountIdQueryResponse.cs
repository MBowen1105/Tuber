using Tuber.Core.Common;
using Tuber.Domain.Dtos;

namespace Tuber.Application.Imports.Queries.ImportGetByInstitutionAccountId;
public class ImportGetByInstitutionAccountIdQueryResponse : CommandQueryResponseBase
{
    public int TotalImportRowCount { get; set; }
    public int ValidImportRowCount { get; set; }
    public int InvalidImportRowCount { get; set; }
    public List<GetImportByInstitutionAccountId_Import> Imports { get; init; } = new();
}
