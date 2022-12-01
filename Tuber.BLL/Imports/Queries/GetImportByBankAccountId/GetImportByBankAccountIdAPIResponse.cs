using Tuber.Domain.Dtos;

namespace Tuber.BLL.Imports.Queries.GetImportByBankAccountId;
public class GetImportByBankAccountIdAPIResponse
{
    public IEnumerable<ImportDto> Imports { get; init; } = new List<ImportDto>();
}
