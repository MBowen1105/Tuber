namespace Tuber.BLL.Banks.Commands.BankUpdate;
public class BankUpdateAPIRequest
{
    public Guid Id { get; init; }
    public string Name { get; init; } = "";
    public int OrderBy { get; init; }
}
