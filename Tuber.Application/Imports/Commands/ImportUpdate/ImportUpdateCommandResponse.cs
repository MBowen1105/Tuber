using Tuber.Core.Common;

namespace Tuber.Application.Imports.Commands.ImportUpdate;

public class ImportUpdateCommandResponse : CommandQueryResponseBase
{
    public ImportUpdateCommandResponse()
    {
        ImportId = Guid.Empty;
        DescriptionValue = "";
        CategoryId = Guid.Empty;
        SubcategoryId = null;
        CategoryName = "";
        SubcategoryName = "";
        Notes = "";
    }

    public Guid ImportId { get; init; }
    public string DescriptionValue { get; init; } = "";
    public Guid CategoryId { get; init; }
    public string CategoryName { get; init; } = "";
    public Guid? SubcategoryId { get; init; }
    public string SubcategoryName { get; init; } = "";
    public string Notes { get; init; } = "";
}
