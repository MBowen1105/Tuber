using MediatR;
using Tuber.Application.API.Common;

namespace Tuber.Application.Banks.Queries.BankGetPaged;
public class BankGetPagedQueryRequest : PagedRequest, IRequest<BankGetPagedQueryResponse>
{
}
