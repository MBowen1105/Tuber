using MediatR;
using Tuber.Domain.API.Common;

namespace Tuber.BLL.BankAccounts.Queries.BankAccountGetPaged;
public class BankAccountGetPagedQueryRequest : PagedRequest, IRequest<BankAccountGetPagedQueryResponse>
{
}
