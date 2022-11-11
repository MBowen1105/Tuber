using Tuber.Domain.Models;

namespace Tuber.Domain.Dtos;
public class BankDto : AuditableEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; } = "";
    public int OrderBy { get; set; } = 0;
}
