namespace Tuber.BLL.Banks.Commands.AddBank;
public class AddBankAPIResponse
{
    public Guid Id { get; init; }
    public string Name { get; set; } = "";
    public int OrderBy { get; init; }
    public string CreatedByUserName { get; init; } = "";
    public DateTime CreatedOnUtc { get; init; }
}
