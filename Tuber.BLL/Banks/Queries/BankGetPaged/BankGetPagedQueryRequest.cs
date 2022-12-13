using MediatR;
using Tuber.Domain.API.Common;

namespace Tuber.BLL.Banks.Queries.BankGetPaged;
public class BankGetPagedQueryRequest : PagedRequest, IRequest<BankGetPagedQueryResponse>
{
}
