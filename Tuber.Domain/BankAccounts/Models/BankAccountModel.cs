using Tuber.Domain.Entities;

namespace Tuber.Domain.BankAccounts.Models;
public class BankAccountModel : EntityBase
{
    public Guid BankId { get; set; }
    public string? Name { get; set; }
    public int OrderBy { get; set; }
}
