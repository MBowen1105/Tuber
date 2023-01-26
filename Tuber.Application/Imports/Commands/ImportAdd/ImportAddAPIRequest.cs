namespace Tuber.Application.Imports.Commands.ImportAdd;
public class ImportAddAPIRequest
{
    public Guid InstitutionAccountId { get; init; }
    public bool SuggestCategorisation { get; init; } = true;
    public string ImportFileName { get; set; } = "";
}
