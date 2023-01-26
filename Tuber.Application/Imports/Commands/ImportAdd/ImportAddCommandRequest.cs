using MediatR;

namespace Tuber.Application.Imports.Commands.ImportAdd;
public class ImportAddCommandRequest : IRequest<ImportAddCommandResponse>
{
    public Guid InstitutionAccountId { get; init; }
    public bool SuggestCategorisation { get; init; }=true;
    public string ImportFileName { get; set; } = "";
}
