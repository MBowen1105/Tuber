using MediatR;

namespace Tuber.BLL.Imports.Queries;
public class GetImportByBankAccountIdQueryRequest : IRequest<GetImportByBankAccountIdQueryResponse>
{
    public Guid BankAccountId { get; init; }
}
