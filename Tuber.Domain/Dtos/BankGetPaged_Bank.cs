﻿using Tuber.Application.Models;

namespace Tuber.Application.Dtos;
public class BankGetPaged_Bank
{
    public Guid BankId { get; init; }
    public string BankName { get; init; } = "";
    public int OrderBy { get; init; } = 0;
    public List<BankGetPaged_BankAccount> BankAccounts { get; set; } = new();
    public string CreatedByUserFullName { get; init; } = "";
    public DateTime CreatedOnUtc { get; init; }
    public string? UpdatedByUserFullName { get; init; }
    public DateTime UpdatedOnUtc { get; init; }
}
