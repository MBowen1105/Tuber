using MediatR;
using Tuber.Core.ValueObjects;

namespace Tuber.BLL.Banks.Queries.GetBank;
public class GetBankQueryRequest : IRequest<GetBankQueryResponse>
{
    public ISO8601Date FromDate { get; set; }
    public PositiveInt NumberOfDays { get; set; }
}
