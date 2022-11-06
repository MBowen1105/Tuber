using System.ComponentModel.DataAnnotations;

namespace Tuber.Domain.Models;
public class Bank : EntityBase
{
    [Required]
    [MaxLength(40)]
    public string? Name { get; set; }
    [Range(0, int.MaxValue)]
    public int OrderBy { get; set; }
}
