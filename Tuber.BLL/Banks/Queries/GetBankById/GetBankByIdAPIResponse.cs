﻿using Tuber.Domain.Models;

namespace Tuber.BLL.Banks.Queries.GetBankById;
public class GetBankByIdAPIResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; } = "";
    public int OrderBy { get; set; }
    public List<BankAccount> BankAccounts { get; set; }
    public bool IsArchived { get; set; }
}
