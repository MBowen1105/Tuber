using MediatR;
using Tuber.Application.Common.Interfaces;

namespace Tuber.Application.Ledgers.Commands.LedgerAddCredit;

public class LedgerAddCreditCommandHandler
    : IRequestHandler<LedgerAddCreditCommandRequest, LedgerAddCreditCommandResponse>
{
    private readonly ILedgerUpdaterService _ledgerUpdaterService;

    public LedgerAddCreditCommandHandler(ILedgerUpdaterService ledgerUpdaterService)
    {
        _ledgerUpdaterService = ledgerUpdaterService;
    }

    public Task<LedgerAddCreditCommandResponse> Handle(LedgerAddCreditCommandRequest request, CancellationToken cancellationToken)
    {
        var serviceResult = _ledgerUpdaterService.AddCredit(request.InstitutionAccountId, request.DateUtc,
             request.Description, request.Reference, request.TransactionType,
             request.MoneyIn, request.CategoryId, request.SubcategoryId);

        return Task.FromResult(new LedgerAddCreditCommandResponse
        {
            LedgerId = serviceResult.Payload.LedgerId,
        });
    }
}
