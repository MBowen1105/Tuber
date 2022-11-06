using Tuber.Domain.Models;

namespace Tuber.Domain.Dtos;
public class BankAccountDto : EntityBase
{
    public string? Name { get; set; } = "";
    public int OrderBy { get; set; } = 0;
    public string BankName { get; set; } = "";
    public int BankOrderBy { get; set; } = 0;
}
