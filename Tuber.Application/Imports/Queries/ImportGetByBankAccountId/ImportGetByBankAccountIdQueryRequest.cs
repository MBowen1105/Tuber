using MediatR;

namespace Tuber.Application.Imports.Queries.ImportGetByInstitutionAccountId;
public class ImportGetByInstitutionAccountIdQueryRequest : IRequest<ImportGetByInstitutionAccountIdQueryResponse>
{
    public Guid InstitutionAccountId { get; init; }
}
