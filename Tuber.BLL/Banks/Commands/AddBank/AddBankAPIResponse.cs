namespace Tuber.BLL.Banks.Commands.AddBank;
public class AddBankAPIResponse
{
    public Guid Id { get; init; }
    public string Name { get; set; } = "";
    public int OrderBy { get; init; }
    public Guid CreatedByUserId { get; init; }
    public DateTime CreatedOn { get; init; }
}
