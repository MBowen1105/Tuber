using MediatR;
using Tuber.Domain.API.Common;

namespace Tuber.BLL.Banks.Queries.GetBank;
public class GetBankPagedQueryRequest : PagedRequest, IRequest<GetBankPagedQueryResponse>
{
}
