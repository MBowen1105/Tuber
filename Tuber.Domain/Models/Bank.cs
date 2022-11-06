namespace Tuber.Domain.Models;
public class Bank : EntityBase
{
    public string? Name { get; set; }
    public int OrderBy { get; set; }
    public ICollection<BankAccount>? BankAccounts { get; set; }
}
