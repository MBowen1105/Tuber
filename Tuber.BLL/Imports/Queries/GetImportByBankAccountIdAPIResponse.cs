using Tuber.Domain.Dtos;

namespace Tuber.BLL.Imports.Queries;
public class GetImportByBankAccountIdAPIResponse
{
    public IEnumerable<ImportDto> Imports { get; init; } = new List<ImportDto>();
}
