using MediatR;

namespace Tuber.Application.Imports.Queries.ImportGetByBankAccountId;
public class ImportGetByBankAccountIdQueryRequest : IRequest<ImportGetByBankAccountIdQueryResponse>
{
    public Guid BankAccountId { get; init; }
}
