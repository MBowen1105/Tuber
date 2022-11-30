namespace Tuber.BLL.BankAccounts.Queries.GetBankAccountById;
public class GetBankAccountByIdAPIResponse
{
    public Guid BankAccountId { get; init; }
    public Guid BankId { get; init; }
    public string Name { get; init; } = "";
    public string UKBankAccount { get; init; } = "";
    public int OrderBy { get; init; }
}
