namespace Tuber.Domain.Models;
public class BankAccount : EntityBase
{
    public string? Name { get; set; }
    public int OrderBy { get; set; }
    public Guid BankId { get; set; }
    public Bank Bank { get; set; }
}
