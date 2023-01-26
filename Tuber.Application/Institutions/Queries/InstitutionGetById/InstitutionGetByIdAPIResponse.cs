using Tuber.Domain.Dtos;

namespace Tuber.Application.Institutions.Queries.InstitutionGetById;
public class InstitutionGetByIdAPIResponse
{
    public Guid InstitutionId { get; init; }
    public string InstitutionName { get; init; } = "";
    public int OrderBy { get; init; }
    public List<InstitutionGetById_InstitutionAccount> InstitutionAccounts { get; init; } = new();
}
