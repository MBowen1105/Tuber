using Tuber.Core.Common;
using Tuber.Domain.Dtos;

namespace Tuber.BLL.Banks.Queries.GetBankById;
public class GetBankByIdQueryResponse : CommandQueryResponseBase
{
    public Guid Id { get; init; }
    public string Name { get; init; } = "";
    public int OrderBy { get; init; }
    public List<BankAccountDto> BankAccounts { get; init; } = new();
}
