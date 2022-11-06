using System.ComponentModel.DataAnnotations;

namespace Tuber.Domain.Models;
public class BankAccount : EntityBase
{
    [Required]
    [MaxLength(40)]
    public string? Name { get; set; }
    [Range(0, int.MaxValue)]
    public int OrderBy { get; set; }
    public Guid BankId { get; set; }
    public virtual Bank? Bank { get; set; }
}
