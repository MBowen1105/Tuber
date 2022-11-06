using MediatR;
using Tuber.Domain.API.Common;

namespace Tuber.BLL.BankAccounts.Queries.GetBankAccount;
public class GetBankAccountPagedQueryRequest : PagedRequest, IRequest<GetBankAccountPagedQueryResponse>
{
}
