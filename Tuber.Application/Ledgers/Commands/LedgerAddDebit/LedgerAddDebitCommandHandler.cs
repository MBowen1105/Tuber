using MediatR;
using Tuber.Application.Common.Interfaces;

namespace Tuber.Application.Ledgers.Commands.LedgerAddDebit;

public class LedgerAddDebitCommandHandler
    : IRequestHandler<LedgerAddDebitCommandRequest, LedgerAddDebitCommandResponse>
{
    private readonly ILedgerUpdaterService _ledgerUpdaterService;

    public LedgerAddDebitCommandHandler(ILedgerUpdaterService ledgerUpdaterService)
    {
        _ledgerUpdaterService = ledgerUpdaterService;
    }

    public Task<LedgerAddDebitCommandResponse> Handle(LedgerAddDebitCommandRequest request, CancellationToken cancellationToken)
    {
        var serviceResult = _ledgerUpdaterService.AddDebit(request.InstitutionAccountId, request.DateUtc,
             request.Description, request.Reference, request.TransactionType,
             request.MoneyOut, request.CategoryId, request.SubcategoryId);

        return Task.FromResult(new LedgerAddDebitCommandResponse
        {
            LedgerId = serviceResult.Payload.LedgerId,
        });
    }
}
