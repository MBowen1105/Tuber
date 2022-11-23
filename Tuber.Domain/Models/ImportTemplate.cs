using Tuber.Domain.Common;

namespace Tuber.Domain.Models;
public class ImportTemplate : AuditableEntity
{
    public Guid ImportTemplateId { get; set; }
    public string TemplateName { get; set; } = "";
    public string? ImportFileName { get; set; }
    public int HeaderRowCount { get; set; } = 1;
    public int? DateColumnNumber { get; set; }
    public int? DescriptionOnStatementColumnNumber { get; set; }
    public int? TransactionTypeColumnNumber { get; set; }
    public int? MoneyInColumnNumber { get; set; }
    public int? MoneyOutColumnNumber { get; set; }
    public int? BalanceOnStatementColumnNumber { get; set; }
    public int? SortCodeColumnNumber { get; set; }
    public int? AccountNumberColumnNumber { get; set; }
    public bool IsDeleted { get; set; }
}
