using MediatR;

namespace Tuber.Application.InstitutionAccounts.Queries.InstitutionAccountGetById;
public class InstitutionAccountGetByIdQueryRequest : IRequest<InstitutionAccountGetByIdQueryResponse>
{
    public Guid InstitutionAccountId { get; set; }
}
