using Tuber.Domain.Entities;

namespace Tuber.Domain.Banks.Models;
public class BankModel : EntityBase
{
    public string? Name { get; set;}
    public int OrderBy { get; set; }
}
