using Tuber.Domain.Models;

namespace Tuber.Domain.Dtos;
public class BankDto : EntityBase
{
    public string? Name { get; set; } = "";
    public int OrderBy { get; set; } = 0;
    public ICollection<BankAccount>? BankAccounts { get; set; }
}
