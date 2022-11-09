using MediatR;

namespace Tuber.BLL.Banks.Queries.GetBankById;
public class GetBankByIdQueryRequest : IRequest<GetBankByIdQueryResponse>
{
    public Guid BankId { get; set; }
}
