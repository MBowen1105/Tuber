﻿using Tuber.Application.Enums;

namespace Tuber.Domain.Models;
public class Import
{
    public static readonly string FriendlyName = "Import";

    public Guid ImportId { get; set; }
    public Guid BankAccountId { get; set; }
    public int ImportRowNumber { get; set; }
    public string? DateValueISO8601 { get; set; }
    public string? DescriptionOnStatementValue { get; set; }
    public string? DescriptionValue { get; set; }
    public string? ReferenceOnStatementValue { get; set; }
    public string? TransactionTypeValue { get; set; }
    public string? MoneyInValue { get; set; }
    public string? MoneyOutValue { get; set; }
    public string? BalanceOnStatementValue { get; set; }
    public string? SortCodeValue { get; set; }
    public string? AccountNumberValue { get; set; }
    public Guid? CategoryId { get; set; }
    public Guid? SubcategoryId { get; set; }
    public string? Notes { get; set; }
    public ImportRowStatus ImportRowStatus { get; set; }
    public string? ValidationFailureMessages { get; set; }
    public Guid ImportedByUserId { get; set; }
    public DateTime ImportedUtc { get; set; }
    
}
