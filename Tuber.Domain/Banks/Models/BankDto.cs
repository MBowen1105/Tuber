using Tuber.Domain.Entities;

namespace Tuber.Domain.Banks.Models;
public class BankDto : EntityBase
{
    public string? Name { get; set; } = "";
    public int OrderBy { get; set; } = 0;
}
