using MediatR;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.FileSystem;
using Tuber.Application.Exceptions;

namespace Tuber.Application.Imports.Commands.ImportAdd;

public class ImportAddCommandHandler : IRequestHandler<ImportAddCommandRequest, ImportAddCommandResponse>
{
    private readonly IFileSystem _fileSystem;
    private readonly IBankAccountRetrievalService _bankAccountRetrievalService;
    private readonly IImportValidationService _importvalidationService;
    private readonly IImportUpdaterService _importUpdaterService;


    public ImportAddCommandHandler(
        IFileSystem fileSystem,
        IBankAccountRetrievalService importTemplateRetrievalService,
        IImportValidationService importValidationService,
        IImportUpdaterService importUpdaterService)
    {
        _fileSystem = fileSystem;
        _bankAccountRetrievalService = importTemplateRetrievalService;
        _importvalidationService = importValidationService;
        _importUpdaterService = importUpdaterService;
    }

    public Task<ImportAddCommandResponse> Handle(
        ImportAddCommandRequest request,
        CancellationToken cancellationToken)
    {
        //  Get appropriate Import Template ID from the BankAccount.
        var bankAccountRetrievalServiceResult = _bankAccountRetrievalService.GetById(request.BankAccountId);
        if (bankAccountRetrievalServiceResult.HasFailed)
        {
            return Task.FromResult(new ImportAddCommandResponse
            {
                Exceptions = bankAccountRetrievalServiceResult.Exceptions,
            });
        }

        //  Save Import Template if one is defined
        var importTemplate = bankAccountRetrievalServiceResult.Payload.ImportTemplate;
        if (importTemplate == null)
            return Task.FromResult(new ImportAddCommandResponse
            {
                Exceptions = new List<Exception> {
                    new BankAccountHasNoImportTemplateDefinedException(bankAccountRetrievalServiceResult.Payload.BankAccountName)
                }
            });

        //  Does the Text Import File exist?
        var workingDirectory = _fileSystem.CurrentDirectory();
        var projectDirectory = _fileSystem.GetParent(workingDirectory)!.FullName;

        var importFileUrl = $@"{projectDirectory}\Tuber.FileSystem\Import Folder\{request.ImportFileName}";

        if (!_fileSystem.Exists(importFileUrl))
            return Task.FromResult(new ImportAddCommandResponse
            {
                Exceptions = new List<Exception>{
                    new InvalidImportFileException(importFileUrl, "Import File does not exist")
                }
            });

        var allRows = _fileSystem.ReadAllLines(importFileUrl);
        if (allRows.Length == 0)
            return Task.FromResult(new ImportAddCommandResponse
            {
                Exceptions = new List<Exception>()
                {
                    new InvalidImportFileException(importFileUrl, "Import File is empty")
                }
            });

        var importValidationServiceResult = _importvalidationService.Validate(
            importTemplate,
            request.BankAccountId,
            request.SuggestCategorisation,
            allRows);

        if (importValidationServiceResult.HasFailed)
        {
            return Task.FromResult(new ImportAddCommandResponse
            {
                Exceptions = importValidationServiceResult.Exceptions
            });
        }

        var importUpdaterServiceResult = _importUpdaterService.Add(
            request.BankAccountId,
            importValidationServiceResult.Payload);

        return Task.FromResult(new ImportAddCommandResponse
        {
            BankAccountId = request.BankAccountId,
            ImportFileName = request.ImportFileName,
            TotalImportRowCount = importUpdaterServiceResult.Payload.TotalRowCount,
            ValidImportRowCount = importUpdaterServiceResult.Payload.ValidRowCount,
            InvalidImportRowCount = importUpdaterServiceResult.Payload.InvalidRowCount,
        });
    }
}
