namespace Tuber.Application.Imports.Commands.ImportUpdate;
public class ImportUpdateAPIRequest
{
    public Guid ImportId { get; init; }
    public Guid CategorySubcategoryId { get; init; }
    public string Notes { get; init; } = "";
}
