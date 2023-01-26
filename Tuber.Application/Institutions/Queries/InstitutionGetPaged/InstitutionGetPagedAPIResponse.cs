using Tuber.Application.API.Common;
using Tuber.Domain.Dtos;

namespace Tuber.Application.Institutions.Queries.InstitutionGetPaged;
public class InstitutionGetPagedAPIResponse : PagedAPIResponse
{
    public int InstitutionCount { get; init; }
    public List<InstitutionGetPaged_Institution> Institutions { get; init; } = new();
}
