namespace Tuber.Application.Imports.Commands.ImportUpdate;
public class ImportUpdateAPIRequest
{
    public Guid ImportId { get; init; }
    public Guid CategoryId { get; init; }
    public Guid SubcategoryId { get; init; }
    public string Notes { get; init; } = "";
}
