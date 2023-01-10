using AutoMapper;
using MediatR;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Exceptions;

namespace Tuber.Application.Imports.Commands.ImportAccept
{
    public class ImportAcceptCommandHandler : IRequestHandler<ImportAcceptCommandRequest, ImportAcceptCommandResponse>
    {
        private readonly IImportRetrievalService _importRetrievalService;
        private readonly ILedgerUpdaterService _ledgerUpdaterService;

        public ImportAcceptCommandHandler(
            IImportRetrievalService importRetrievalService,
            ILedgerUpdaterService ledgerUpdaterService)
        {
            _importRetrievalService = importRetrievalService;
            _ledgerUpdaterService = ledgerUpdaterService;
        }

        public Task<ImportAcceptCommandResponse> Handle(ImportAcceptCommandRequest request, CancellationToken cancellationToken)
        {
            //  Get all imports for the given bank account.
            var getImportServiceResult = _importRetrievalService.GetByBankAccountId(request.BankAccountId);

            if (getImportServiceResult.HasFailed)
                return Task.FromResult(new ImportAcceptCommandResponse
                {
                    BankAccountId = request.BankAccountId,
                    TotalAcceptedRowCount = 0,
                    Exceptions = getImportServiceResult.Exceptions,
                });

            //  Check to ensue that every transaction on the inport has been coded.
            var hasUncodedItems = getImportServiceResult
                .Payload.Any(x => x.SuggestedCategorySubcategoryId == null);
            if (hasUncodedItems)
                return Task.FromResult(new ImportAcceptCommandResponse
                {
                    BankAccountId = request.BankAccountId,
                    TotalAcceptedRowCount = 0,
                    Exceptions = new List<Exception>
                    {
                        new ImportHasUnassignedCategoriesException(request.BankAccountId),
                    }
                });

            //  Copy the coded imports to the appropriate Ledger.
            var serviceResult = _ledgerUpdaterService.Accept(
                request.BankAccountId,
                getImportServiceResult.Payload);

            var response = new ImportAcceptCommandResponse
            {
                BankAccountId = serviceResult.Payload.BankAccountId,
                TotalAcceptedRowCount = serviceResult.Payload.TotalAcceptedRowCount,
                Exceptions = serviceResult.Exceptions,
            };

            return Task.FromResult(response);
        }
    }
}
