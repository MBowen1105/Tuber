using MediatR;

namespace Tuber.Application.Institutions.Queries.InstitutionGetById;
public class InstitutionGetByIdQueryRequest : IRequest<InstitutionGetByIdQueryResponse>
{
    public Guid InstitutionId { get; set; }
}
