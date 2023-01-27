using Tuber.Core.Common;
using Tuber.Domain.Dtos;

namespace Tuber.Application.InstitutionAccounts.Queries.InstitutionAccountGetPaged;
public class InstitutionAccountGetPagedQueryResponse : PagedQueryResponseBase
{
    public int InstitutionAccountCount { get; init; } = 0;
    public List<InstitutionAccountGetPaged_InstitutionAccount> InstitutionAccounts { get; init; } = new();
}
