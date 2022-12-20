using MediatR;

namespace Tuber.Application.Banks.Queries.BankGetById;
public class BankGetByIdQueryRequest : IRequest<BankGetByIdQueryResponse>
{
    public Guid BankId { get; set; }
}
