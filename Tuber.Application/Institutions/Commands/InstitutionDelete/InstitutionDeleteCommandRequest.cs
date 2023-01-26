using MediatR;

namespace Tuber.Application.Institutions.Commands.InstitutionDelete;
public class InstitutionDeleteCommandRequest : IRequest<InstitutionDeleteCommandResponse>
{
    public Guid InstitutionId { get; set; }
}
