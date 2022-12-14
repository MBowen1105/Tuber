namespace Tuber.BLL.Banks.Commands.BankUpdate;
public class BankUpdateAPIRequest
{
    public Guid BankId { get; init; }
    public string Name { get; init; } = "";
    public int OrderBy { get; init; }
}
