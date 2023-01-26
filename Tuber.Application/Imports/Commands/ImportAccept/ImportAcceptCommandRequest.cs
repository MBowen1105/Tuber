using MediatR;

namespace Tuber.Application.Imports.Commands.ImportAccept;
public class ImportAcceptCommandRequest : IRequest<ImportAcceptCommandResponse>
{
    public Guid InstitutionAccountId { get; init; }
}
