using Tuber.Domain.Common;

namespace Tuber.Domain.Dtos;
public class BankAccountDto : AuditableEntity
{
    public Guid Id { get; set; }
    public string? Name { get; set; } = "";
    public int OrderBy { get; set; } = 0;
    public string BankName { get; set; } = "";
    public int BankOrderBy { get; set; } = 0;
}
