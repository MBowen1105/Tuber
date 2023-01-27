using Tuber.Core.Common;

namespace Tuber.Application.InstitutionAccounts.Queries.InstitutionAccountGetById;
public class InstitutionAccountGetByIdQueryResponse : CommandQueryResponseBase
{
    public Guid InstitutionAccountId { get; init; }
    public Guid InstitutionId { get; init; }
    public string InstitutionAccountName { get; init; } = "";
    public string UKSortCode { get; init; } = "";
    public string UKInstitutionAccount { get; init; } = "";
    public int OrderBy { get; init; }
    public string CreatedByUserFullName { get; init; } = "";
    public DateTime CreatedOnUtc { get; init; }
    public string? UpdatedByUserFullName { get; init; } = "";
    public DateTime? UpdatedOnUtc { get; init; }
}
