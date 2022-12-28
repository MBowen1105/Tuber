using MediatR;
using Tuber.Application.API.Common;

namespace Tuber.Application.BankAccounts.Queries.BankAccountGetPaged;
public class BankAccountGetPagedQueryRequest : PagedRequest, IRequest<BankAccountGetPagedQueryResponse>
{
}
