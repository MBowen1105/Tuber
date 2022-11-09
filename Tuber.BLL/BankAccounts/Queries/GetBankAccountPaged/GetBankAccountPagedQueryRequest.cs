using MediatR;
using Tuber.Domain.API.Common;

namespace Tuber.BLL.BankAccounts.Queries.GetBankAccountPaged;
public class GetBankAccountPagedQueryRequest : PagedRequest, IRequest<GetBankAccountPagedQueryResponse>
{
}
