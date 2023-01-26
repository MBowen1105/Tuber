using Tuber.Core.Common;
using Tuber.Domain.Dtos;

namespace Tuber.Application.Institutions.Queries.InstitutionGetPaged;
public class InstitutionGetPagedQueryResponse : PagedQueryResponseBase
{
    public int InstitutionCount { get; init; } = 0;
    public List<InstitutionGetPaged_Institution> Institutions { get; init; } = new();
}
