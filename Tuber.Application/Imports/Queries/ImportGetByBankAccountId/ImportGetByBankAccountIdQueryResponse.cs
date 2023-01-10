using Tuber.Core.Common;
using Tuber.Domain.Dtos;

namespace Tuber.Application.Imports.Queries.ImportGetByBankAccountId;
public class ImportGetByBankAccountIdQueryResponse : CommandQueryResponseBase
{
    public int TotalImportRowCount { get; set; }
    public int ValidImportRowCount { get; set; }
    public int InvalidImportRowCount { get; set; }
    public List<GetImportByBankAccountId_Import> Imports { get; init; } = new();
}
