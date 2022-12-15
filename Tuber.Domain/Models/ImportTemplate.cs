using Tuber.Domain.Common;

namespace Tuber.Domain.Models;
public class ImportTemplate : AuditableEntity
{
    public static readonly string FriendlyName = "Import Template";

    public ImportTemplate()
    {
        ImportTemplateId = Guid.Empty;
        ImportTemplateName = "";
        ImportFileName = "";
        ExpectedHeaderRowCount = 0;
        ExpectedColumnCount = 0;
        SeperatorChar = ',';
        DateTemplate = "";
        DateColumnNumber = 0;
        DescriptionOnStatementColumnNumber = 0;
        ReferenceOnStatementStartCharacter = 14;
        TransactionTypeColumnNumber = 0;
        MoneyInColumnNumber = 0;
        MoneyOutColumnNumber = 0;
        BalanceOnStatementColumnNumber = 0;
        SortCodeColumnNumber = 0;
        AccountNumberColumnNumber = 0;
        IsDeleted = false;
    }

    public Guid ImportTemplateId { get; set; }
    public string ImportTemplateName { get; set; }
    public string ImportFileName { get; set; }
    public int ExpectedHeaderRowCount { get; set; }
    public int ExpectedColumnCount { get; set; }
    public char SeperatorChar { get; set; }
    public string DateTemplate { get; set; }
    public int DateColumnNumber { get; set; }
    public int DescriptionOnStatementColumnNumber { get; set; }
    public int ReferenceOnStatementStartCharacter { get; set; }
    public int TransactionTypeColumnNumber { get; set; }
    public int MoneyInColumnNumber { get; set; }
    public int MoneyOutColumnNumber { get; set; }
    public int BalanceOnStatementColumnNumber { get; set; }
    public int SortCodeColumnNumber { get; set; }
    public int AccountNumberColumnNumber { get; set; }
    public bool IsDeleted { get; set; }
}
