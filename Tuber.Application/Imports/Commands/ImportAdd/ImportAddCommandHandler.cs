﻿using MediatR;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.FileSystem;
using Tuber.Application.Exceptions;

namespace Tuber.Application.Imports.Commands.ImportAdd;

public class ImportAddCommandHandler : IRequestHandler<ImportAddCommandRequest, ImportAddCommandResponse>
{
    private readonly IFileSystem _fileSystem;
    private readonly IInstitutionAccountRetrievalService _bankAccountRetrievalService;
    private readonly IImportValidationService _importvalidationService;
    private readonly IImportUpdaterService _importUpdaterService;


    public ImportAddCommandHandler(
        IFileSystem fileSystem,
        IInstitutionAccountRetrievalService importTemplateRetrievalService,
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
        //  Get appropriate Import Template ID from the InstitutionAccount.
        var bankAccountRetrievalServiceResult = _bankAccountRetrievalService.GetById(request.InstitutionAccountId);
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
                    new InstitutionAccountHasNoImportTemplateDefinedException(bankAccountRetrievalServiceResult.Payload.InstitutionAccountName)
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
            request.InstitutionAccountId,
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
            request.InstitutionAccountId,
            importValidationServiceResult.Payload);

        return Task.FromResult(new ImportAddCommandResponse
        {
            InstitutionAccountId = request.InstitutionAccountId,
            ImportFileName = request.ImportFileName,
            TotalImportRowCount = importUpdaterServiceResult.Payload.TotalRowCount,
            CategorisedRowCount = importUpdaterServiceResult.Payload.CategorisedRowCount,
            UncategorisedRowCount = importUpdaterServiceResult.Payload.UncategorisedRowCount,
            ValidImportRowCount = importUpdaterServiceResult.Payload.ValidRowCount,
            InvalidImportRowCount = importUpdaterServiceResult.Payload.InvalidRowCount,
        });
    }
}
