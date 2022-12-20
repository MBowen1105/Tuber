namespace Tuber.Application.Banks.Commands.BankAdd;
public class BankAddAPIResponse
{
    public Guid BankId { get; init; }
    public string BankName { get; set; } = "";
    public int OrderBy { get; init; }
}
