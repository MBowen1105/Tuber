using MediatR;
using System.Security.Cryptography.X509Certificates;
using Tuber.BLL.Imports.Services;
using Tuber.Domain.Exceptions;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Interfaces.FileSystem;
using Tuber.Domain.Models;

namespace Tuber.BLL.Imports.Commands.AddImport;

public class AddImportCommandHandler : IRequestHandler<AddImportCommandRequest, AddImportCommandResponse>
{
    private readonly IFileSystem _fileSystem;
    private readonly IImportTemplateRetrievalService _importTemplateRetrievalService;
    private readonly IImportValidationService _importvalidationService;
    private readonly IImportUpdaterService _importUpdaterService;
    public AddImportCommandHandler(
        IFileSystem fileSystem,
        IImportTemplateRetrievalService importTemplateRetrievalService,
        IImportValidationService importValidationService,
        IImportUpdaterService importUpdaterService)
    {
        _fileSystem = fileSystem;
        _importTemplateRetrievalService = importTemplateRetrievalService;
        _importvalidationService = importValidationService;
        _importUpdaterService = importUpdaterService;
    }

    public Task<AddImportCommandResponse> Handle(AddImportCommandRequest request, CancellationToken cancellationToken)
    {
        //  Get appropriate Import Template.
        var importTemplateRetrievalServiceResult = _importTemplateRetrievalService.GetById(request.ImportTemplateId);
        if (importTemplateRetrievalServiceResult.HasFailed)
        {
            return Task.FromResult(new AddImportCommandResponse
            {
                Exceptions = importTemplateRetrievalServiceResult.Exceptions,
            });
        }

        //  Save valid Import Template
        var importTemplate = importTemplateRetrievalServiceResult.Payload;

        //  Does the Text Import File exist?
        var workingDirectory = Environment.CurrentDirectory;
        var projectDirectory = Directory.GetParent(workingDirectory)!.FullName;
        var importFileUrl = $@"{projectDirectory}\Tuber.FileSystem\Import Folder\{request.ImportFileName}";
        if (!_fileSystem.Exists(importFileUrl))
            return Task.FromResult(new AddImportCommandResponse
            {
                Exceptions = new List<Exception>{
                    new InvalidImportFileException(importFileUrl, "Import File does not exist")
                }
            });

        var allRows = _fileSystem.ReadAllLines(importFileUrl);
        if (allRows.Length == 0)
            return Task.FromResult(new AddImportCommandResponse
            {
                Exceptions = new List<Exception>()
                {
                    new InvalidImportFileException(importFileUrl, "Import File is empty")
                }
            });

        var importValidationServiceResult = _importvalidationService.Validate(importTemplate, request.BankAccountId, allRows);
        if (importValidationServiceResult.HasFailed)
        {
            return Task.FromResult(new AddImportCommandResponse
            {
                Exceptions = importValidationServiceResult.Exceptions
            });
        }

        var importUpdaterServiceResult = _importUpdaterService.Add(
            request.BankAccountId,
            importValidationServiceResult.Payload);

        return Task.FromResult(new AddImportCommandResponse
        {
            BankAccountId = request.BankAccountId,
            ImportFileName = request.ImportFileName,
            TotalImportRowCount = importUpdaterServiceResult.Payload.TotalRowCount,
            ValidImportRowCount = importUpdaterServiceResult.Payload.ValidRowCount,
            InvalidImportRowCount = importUpdaterServiceResult.Payload.InvalidRowCount,
        });
    }
}
