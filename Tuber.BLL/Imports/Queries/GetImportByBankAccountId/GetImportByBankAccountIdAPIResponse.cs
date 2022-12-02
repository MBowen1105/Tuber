using Tuber.Domain.Dtos;

namespace Tuber.BLL.Imports.Queries.GetImportByBankAccountId;
public class GetImportByBankAccountIdAPIResponse
{
    public IEnumerable<GetImportByBankAccountId_Import> Imports { get; init; } = new List<GetImportByBankAccountId_Import>();
}
