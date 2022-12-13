using Tuber.Domain.Dtos;

namespace Tuber.BLL.Banks.Queries.BankGetById;
public class BankGetByIdAPIResponse
{
    public Guid BankId { get; init; }
    public string Name { get; init; } = "";
    public int OrderBy { get; init; }
    public Guid? ImportTemplateId { get; init; }
    public List<BankGetById_BankAccount> BankAccounts { get; init; } = new();
    public BankGetById_ImportTemplate? ImportTemplate { get; init; }
}
