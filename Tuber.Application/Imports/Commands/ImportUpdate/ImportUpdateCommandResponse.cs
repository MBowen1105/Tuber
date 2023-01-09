using Tuber.Core.Common;

namespace Tuber.Application.Imports.Commands.ImportUpdate;

public class ImportUpdateCommandResponse : CommandQueryResponseBase
{
    public ImportUpdateCommandResponse()
    {
        ImportId = Guid.Empty;
        DescriptionValue = "";
        CategorySubcategoryId = Guid.Empty;
        CategoryName = "";
        SubcategoryName = "";
        Notes = "";
    }

    public Guid ImportId { get; init; }
    public string DescriptionValue { get; init; } = "";
    public Guid CategorySubcategoryId { get; init; }
    public string CategoryName { get; init; } = "";
    public string SubcategoryName { get; init; } = "";
    public string Notes { get; init; } = "";
}
