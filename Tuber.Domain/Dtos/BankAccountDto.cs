namespace Tuber.Domain.Dtos;
public class BankAccountDto
{
    public Guid Id { get; set; }
    public string? Name { get; set; } = "";
    public int OrderBy { get; set; } = 0;
    public string BankName { get; set; } = "";
    public Guid CreatedByUserId { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid UpdatedByUserId { get; set; }
    public DateTime UpdatedOn { get; set; }
    public bool IsArchived { get; set; }
}
