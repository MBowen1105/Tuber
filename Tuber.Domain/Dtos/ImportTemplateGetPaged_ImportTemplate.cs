namespace Tuber.Domain.Dtos;
public record ImportTemplateGetPaged_ImportTemplate
{
    public Guid ImportTemplateId { get; set; }
    public string TemplateName { get; set; } = "";
    public string ImportFileName { get; set; } = "";
    public int ExpectedHeaderRowCount { get; set; }
    public int ExpectedColumnCount { get; set; }
    public char SeperatorChar { get; set; }
    public string DateTemplate { get; set; } = "";
    public int DateColumnNumber { get; set; }
    public int DescriptionOnStatementColumnNumber { get; set; }
    public int TransactionTypeColumnNumber { get; set; }
    public int MoneyInColumnNumber { get; set; }
    public int MoneyOutColumnNumber { get; set; }
    public int BalanceOnStatementColumnNumber { get; set; }
    public int SortCodeColumnNumber { get; set; }
    public int AccountNumberColumnNumber { get; set; }
}
