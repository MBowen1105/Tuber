using Tuber.Domain.Banks.Models;
using Tuber.Domain.Entities;
using Tuber.Domain.ValueObjects;

namespace Tuber.Domain.BankAccounts.Models;
public class BankDto : EntityBase
{
    public BankModel Bank { get; set; }
    public string? Name { get; set; } = "";
    public UKBankAccount UKBankAccountNumber { get; set; }
    public int OrderBy { get; set; } = 0;
}
