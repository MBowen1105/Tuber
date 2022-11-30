using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.BLL.Banks.Queries.GetBankById;
public class GetBankByIdAPIResponse
{
    public Guid BankId { get; init; }
    public string Name { get; init; } = "";
    public int OrderBy { get; init; }
    public Guid ImportTemplateId { get; init; }
    public List<BankAccountDto> BankAccounts { get; init; } = new();
    public ImportTemplate? ImportTemplate { get; init; }
}
