namespace Tuber.Application.ImportTemplates.Queries.ImportTemplateGetById;
public class ImportTemplateGetByIdAPIResponse
{
    public Guid ImportTemplateId { get; init; }
    public string ImportTemplateName { get; init; } = "";
    public string ImportFileName { get; set; } = "";
    public int ExpectedHeaderRowCount { get; set; }
    public int ExpectedColumnCount { get; set; }
    public char SeperatorChar { get; set; }
    public int DateColumnNumber { get; set; }
    public int DescriptionOnStatementColumnNumber { get; set; }
    public int TransactionTypeColumnNumber { get; set; }
    public int MoneyInColumnNumber { get; set; }
    public int MoneyOutColumnNumber { get; set; }
    public int BalanceOnStatementColumnNumber { get; set; }
    public int SortCodeColumnNumber { get; set; }
    public int AccountNumberColumnNumber { get; set; }
}
