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
            var getImportServiceResult = _importRetrievalService.GetByInstitutionAccountId(request.InstitutionAccountId);

            if (getImportServiceResult.HasFailed)
                return Task.FromResult(new ImportAcceptCommandResponse
                {
                    InstitutionAccountId = request.InstitutionAccountId,
                    TotalAcceptedRowCount = 0,
                    TotalCreatedRowCount = 0,
                    TotalUpdatedRowCount = 0,
                    TotalAlreadyReconciledCount= 0,
                    Exceptions = getImportServiceResult.Exceptions,
                });

            //  Check to ensue that every transaction on the inport has been coded.
            var hasUncodedItems = getImportServiceResult
                .Payload.Any(x => x.CategoryId == null);
            if (hasUncodedItems)
                return Task.FromResult(new ImportAcceptCommandResponse
                {
                    InstitutionAccountId = request.InstitutionAccountId,
                    TotalAcceptedRowCount = 0,
                    TotalCreatedRowCount = 0,
                    TotalUpdatedRowCount = 0,
                    TotalAlreadyReconciledCount = 0,
                    Exceptions = new List<Exception>
                    {
                        new ImportHasUnassignedCategoriesException(request.InstitutionAccountId),
                    }
                });

            //  Copy the coded imports to the appropriate Ledger.
            var serviceResult = _ledgerUpdaterService.Accept(
                request.InstitutionAccountId,
                getImportServiceResult.Payload);

            var response = new ImportAcceptCommandResponse
            {
                InstitutionAccountId = serviceResult.Payload.InstitutionAccountId,
                TotalAcceptedRowCount = serviceResult.Payload.TotalAcceptedRowCount,
                TotalCreatedRowCount = serviceResult.Payload.TotalCreatedRowCount,
                TotalUpdatedRowCount = serviceResult.Payload.TotalUpdatedRowCount,
                TotalAlreadyReconciledCount = serviceResult.Payload.TotalAlreadyReconciledCount,
                Exceptions = serviceResult.Exceptions,
            };

            return Task.FromResult(response);
        }
    }
}
