namespace Tuber.BLL.Imports.Commands.ImportAdd;
public class ImportAddAPIRequest
{
    public Guid ImportTemplateId { get; init; }
    public Guid BankAccountId { get; init; }
    public bool SuggestCategorisation { get; init; } = true;
    public string ImportFileName { get; set; } = "";
}
