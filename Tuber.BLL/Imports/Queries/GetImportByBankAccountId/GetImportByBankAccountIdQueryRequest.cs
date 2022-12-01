using MediatR;

namespace Tuber.BLL.Imports.Queries.GetImportByBankAccountId;
public class GetImportByBankAccountIdQueryRequest : IRequest<GetImportByBankAccountIdQueryResponse>
{
    public Guid BankAccountId { get; init; }
}
