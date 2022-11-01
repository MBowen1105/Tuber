namespace Tuber.Domain.Banks.Models;
public class BankDto
{
    public Guid Id { get; init; }    
    public DateTime Date { get; init; }
    public string Name { get; init; } = "";
}
