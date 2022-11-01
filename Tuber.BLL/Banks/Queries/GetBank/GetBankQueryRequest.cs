using MediatR;
using Tuber.Core.ValueObjects;

namespace Tuber.BLL.Banks.Queries.GetBank;
public class GetBankQueryRequest : IRequest<GetBankQueryResponse>
{
    public PositiveInt PageNumber { get; set; } = PositiveInt.From(1);
    public PositiveInt PageSize { get; set; } = PositiveInt.From(5);
}
