using Tuber.Core.Common;

namespace Tuber.BLL.ImportTemplates.Queries.ImportTemplateGetById;
public class ImportTemplateGetByIdQueryResponse : CommandQueryResponseBase
{
    public ImportTemplateGetByIdQueryResponse()
    {
        ImportTemplateId = Guid.Empty;
        TemplateName = "";
        ImportFileName = "";
        ExpectedHeaderRowCount = 0;
        ExpectedColumnCount = 0;
        SeperatorChar = ',';
        DateColumnNumber = 0;
        DescriptionOnStatementColumnNumber = 0;
        TransactionTypeColumnNumber = 0;
        MoneyInColumnNumber = 0;
        MoneyOutColumnNumber = 0;
        BalanceOnStatementColumnNumber = 0;
        SortCodeColumnNumber = 0;
        AccountNumberColumnNumber = 0;
    }
    public Guid ImportTemplateId { get; init; }
    public string TemplateName { get; init; }
    public string ImportFileName { get; set; }
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
