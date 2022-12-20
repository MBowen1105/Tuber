namespace Tuber.Application.Banks.Commands.BankUpdate;
public class BankUpdateAPIRequest
{
    public Guid BankId { get; init; }
    public string BankName { get; init; } = "";
    public int OrderBy { get; init; }
}
