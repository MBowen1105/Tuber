using MediatR;
using Tuber.Domain.API.Common;

namespace Tuber.BLL.Banks.Queries;
public class GetBankPagedQueryRequest : PagedRequest, IRequest<GetBankPagedQueryResponse>
{
}
