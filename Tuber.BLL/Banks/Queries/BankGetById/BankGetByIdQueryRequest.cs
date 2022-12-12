using MediatR;

namespace Tuber.BLL.Banks.Queries.BankGetById;
public class BankGetByIdQueryRequest : IRequest<BankGetByIdQueryResponse>
{
    public Guid BankId { get; set; }
}
