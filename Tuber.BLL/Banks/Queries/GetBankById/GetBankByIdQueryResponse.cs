using Tuber.BLL.Common;
using Tuber.Domain.Dtos;

namespace Tuber.BLL.Banks.Queries.GetBankById;
public class GetBankByIdQueryResponse : QueryResponseBase
{
    public Guid Id { get; set; }
    public string Name { get; set; } = "";
    public int OrderBy { get; set; }
    public List<BankAccountDto> BankAccounts { get; set; }
    public bool IsArchived { get; set; }
}
