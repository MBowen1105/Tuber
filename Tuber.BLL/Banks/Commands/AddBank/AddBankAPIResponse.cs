namespace Tuber.BLL.Banks.Commands.AddBank;
public class AddBankAPIResponse
{
    public Guid BankId { get; init; }
    public string BankName { get; set; } = "";
    public int OrderBy { get; init; }
}
