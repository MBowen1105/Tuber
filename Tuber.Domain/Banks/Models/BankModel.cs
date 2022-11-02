using Tuber.Domain.Entities;

namespace Tuber.Domain.Banks.Models;
public class BankModel : EntityBase
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public DateTime Date { get; set; }
    public string? Name { get; set;}
}
