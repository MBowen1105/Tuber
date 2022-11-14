using Tuber.Domain.Models;

namespace Tuber.Domain.Dtos;
public class BankDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = "";
    public int OrderBy { get; set; } = 0;
    public List<BankAccount> BankAccounts { get; set; }
    public Guid CreatedByUserId { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid UpdatedByUserId { get; set; }
    public DateTime UpdatedOn { get; set; }
    public bool IsArchived { get; set; }

}
