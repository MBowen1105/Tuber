using MediatR;

namespace Tuber.Application.BankAccounts.Queries.BankAccountGetById;
public class BankAccountGetByIdQueryRequest : IRequest<BankAccountGetByIdQueryResponse>
{
    public Guid BankAccountId { get; set; }
}
