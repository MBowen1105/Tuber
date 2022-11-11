namespace Tuber.BLL.Banks.Commands.PutBank;
public class PutBankAPIResponse
{
    public Guid Id { get; init; }
    public string Name { get; set; } = "";
    public int OrderBy { get; init; }
    public Guid CreatedByUserId { get; init; }
    public DateTime CreatedOn { get; init; }
    public Guid UpdatedByUserId { get; init; }
    public DateTime UpdatedOn { get; init; }
}
