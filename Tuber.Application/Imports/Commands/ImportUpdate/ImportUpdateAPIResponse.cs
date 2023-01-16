namespace Tuber.Application.Imports.Commands.ImportUpdate;
public class ImportUpdateAPIResponse
{
    public Guid ImportId { get; init; }
    public string DescriptionValue { get; init; } = "";
    public Guid CategoryId { get; init; }
    public Guid? SubcategoryId { get; init; }
    public string CategoryName { get; init; } = "";
    public string SubcategoryName { get; init; } = "";
    public string Notes { get; init; } = "";
}
