using MediatR;

namespace Tuber.Application.Imports.Commands.ImportUpdate;
public class ImportUpdateCommandRequest : IRequest<ImportUpdateCommandResponse>
{
    public Guid ImportId { get; init; }
    public Guid CategorySubcategoryId { get; init; }
    public string Notes { get; init; } = "";
}
