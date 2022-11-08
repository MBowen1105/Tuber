using MediatR;

namespace Tuber.BLL.Banks.Queries;
public class GetBankByIdQueryRequest : IRequest<GetBankByIdQueryResponse>
{
    public Guid BankId { get; set; }
}
