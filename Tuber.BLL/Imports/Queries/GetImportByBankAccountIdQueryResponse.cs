using Tuber.Core.Common;
using Tuber.Domain.Dtos;

namespace Tuber.BLL.Imports.Queries;
public class GetImportByBankAccountIdQueryResponse : CommandQueryResponseBase
{
    public IEnumerable<ImportDto> Imports { get; init; } = new List<ImportDto>();
}
