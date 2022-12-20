using MediatR;
using Tuber.Domain.API.Common;

namespace Tuber.Application.BankAccounts.Queries.BankAccountGetPaged;
public class BankAccountGetPagedQueryRequest : PagedRequest, IRequest<BankAccountGetPagedQueryResponse>
{
}
