using MediatR;

namespace Tuber.BLL.Imports.Queries.ImportGetByBankAccountId;
public class ImportGetByBankAccountIdQueryRequest : IRequest<ImportGetByBankAccountIdQueryResponse>
{
    public Guid BankAccountId { get; init; }
}
