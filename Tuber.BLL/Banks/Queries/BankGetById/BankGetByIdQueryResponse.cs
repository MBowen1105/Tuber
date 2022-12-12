using Tuber.Core.Common;
using Tuber.Domain.Dtos;

namespace Tuber.BLL.Banks.Queries.BankGetById;
public class BankGetByIdQueryResponse : CommandQueryResponseBase
{
    public Guid BankId { get; init; }
    public string Name { get; init; } = "";
    public int OrderBy { get; init; }
    public Guid? ImportTemplateId { get; init; }
    public GetBankById_ImportTemplate? ImportTemplate { get; init; }
    public List<GetBankById_BankAccount> BankAccounts { get; init; } = new();
}