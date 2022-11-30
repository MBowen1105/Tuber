using Tuber.Core.Common;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.BLL.Banks.Queries.GetBankById;
public class GetBankByIdQueryResponse : CommandQueryResponseBase
{
    public Guid BankId { get; init; }
    public string Name { get; init; } = "";
    public int OrderBy { get; init; }
    public Guid ImportTemplateId { get; init; }
    public IEnumerable<BankAccountDto> BankAccounts { get; init; } = new List<BankAccountDto>();
    public ImportTemplate? ImportTemplate { get; init; }
}
