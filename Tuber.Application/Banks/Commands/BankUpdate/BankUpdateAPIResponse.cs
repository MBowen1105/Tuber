namespace Tuber.Application.Banks.Commands.BankUpdate;
public class BankUpdateAPIResponse
{
    public Guid Id { get; init; }
    public string BankName { get; init; } = "";
    public int OrderBy { get; init; }
}
