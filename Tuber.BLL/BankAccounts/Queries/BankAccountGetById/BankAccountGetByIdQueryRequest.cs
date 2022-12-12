using MediatR;

namespace Tuber.BLL.BankAccounts.Queries.BankAccountGetById;
public class BankAccountGetByIdQueryRequest : IRequest<BankAccountGetByIdQueryResponse>
{
    public Guid BankAccountId { get; set; }
}
