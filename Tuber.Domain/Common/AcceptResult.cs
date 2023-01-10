namespace Tuber.Domain.Common;
public class AcceptResult
{
    public Guid BankAccountId { get; init; }
    public int TotalAcceptedRowCount { get; init; } = 0;
}
