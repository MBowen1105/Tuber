using Tuber.Application.API.Common;
using Tuber.Domain.Dtos;

namespace Tuber.Application.InstitutionAccounts.Queries.InstitutionAccountGetPaged;
public class InstitutionAccountGetPagedAPIResponse : PagedAPIResponse
{
    public int InstitutionAccountCount { get; init; }
    public List<InstitutionAccountGetPaged_InstitutionAccount> InstitutionAccounts { get; init; } = new();
}
