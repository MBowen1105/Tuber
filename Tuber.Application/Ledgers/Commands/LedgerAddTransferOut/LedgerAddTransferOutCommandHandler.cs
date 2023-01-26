using MediatR;
using Tuber.Application.Common.Interfaces;

namespace Tuber.Application.Ledgers.Commands.LedgerAddTransferOut;

public class LedgerAddTransferOutCommandHandler
    : IRequestHandler<LedgerAddTransferOutCommandRequest, LedgerAddTransferOutCommandResponse>
{
    private readonly ILedgerUpdaterService _ledgerUpdaterService;

    public LedgerAddTransferOutCommandHandler(ILedgerUpdaterService ledgerUpdaterService)
    {
        _ledgerUpdaterService = ledgerUpdaterService;
    }

    public Task<LedgerAddTransferOutCommandResponse> Handle(LedgerAddTransferOutCommandRequest request, CancellationToken cancellationToken)
    {
        var serviceResult = _ledgerUpdaterService.AddTransferOut(request.InstitutionAccountId, request.DateUtc,
             request.Description, request.Reference, request.MoneyOut, request.CategoryId, 
             request.SubcategoryId, request.TransferInstitutionAccountId);

        return Task.FromResult(new LedgerAddTransferOutCommandResponse
        {
            LedgerId = serviceResult.Payload.LedgerId,
        });
    }
}
