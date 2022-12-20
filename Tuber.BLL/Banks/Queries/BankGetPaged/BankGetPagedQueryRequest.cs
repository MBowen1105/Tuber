using MediatR;
using Tuber.Domain.API.Common;

namespace Tuber.Application.Banks.Queries.BankGetPaged;
public class BankGetPagedQueryRequest : PagedRequest, IRequest<BankGetPagedQueryResponse>
{
}
