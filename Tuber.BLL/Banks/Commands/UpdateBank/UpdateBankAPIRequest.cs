namespace Tuber.BLL.Banks.Commands.UpdateBank;
public class UpdateBankAPIRequest
{
    public Guid Id { get; init; }
    public string Name { get; init; } = "";
    public int OrderBy { get; init; }
}
