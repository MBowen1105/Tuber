using MediatR;

namespace Tuber.Application.Institutions.Commands.InstitutionAdd;
public class InstitutionAddCommandRequest : IRequest<InstitutionAddCommandResponse>
{
    public string InstitutionName { get; set; } = "";
    public int OrderBy { get; set; }
}
