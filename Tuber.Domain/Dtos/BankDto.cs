namespace Tuber.Domain.Dtos;
public record BankDto
{
    public Guid Id { get; init; }
    public string Name { get; init; } = "";
    public int OrderBy { get; init; } = 0;
    public List<BankAccountDto> BankAccounts { get; set; } = new();
    public Guid CreatedByUserId { get; init; }
    public DateTime CreatedOn { get; init; }
    public Guid UpdatedByUserId { get; init; }
    public DateTime UpdatedOn { get; init; }
    public bool IsArchived { get; init; }

}
