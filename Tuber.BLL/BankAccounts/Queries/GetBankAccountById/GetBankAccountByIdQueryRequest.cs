using MediatR;

namespace Tuber.BLL.BankAccounts.Queries.GetBankAccountById;
public class GetBankAccountByIdQueryRequest : IRequest<GetBankAccountByIdQueryResponse>
{
    public Guid BankAccountId { get; set; }
}
