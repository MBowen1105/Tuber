using MediatR;
using Tuber.Domain.Exceptions;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Interfaces.FileSystem;

namespace Tuber.BLL.Imports.Commands.ImportAdd;

public class ImportAddCommandHandler : IRequestHandler<ImportAddCommandRequest, ImportAddCommandResponse>
{
    private readonly IFileSystem _fileSystem;
    private readonly IImportTemplateRetrievalService _importTemplateRetrievalService;
    private readonly IImportValidationService _importvalidationService;
    private readonly IImportUpdaterService _importUpdaterService;
    private readonly ICategorySubcategoryRetrievalService _categoryRetrievalService;


    public ImportAddCommandHandler(
        IFileSystem fileSystem,
        IImportTemplateRetrievalService importTemplateRetrievalService,
        IImportValidationService importValidationService,
        IImportUpdaterService importUpdaterService,
        ICategorySubcategoryRetrievalService categoryRetrievalService)
    {
        _fileSystem = fileSystem;
        _importTemplateRetrievalService = importTemplateRetrievalService;
        _importvalidationService = importValidationService;
        _importUpdaterService = importUpdaterService;
        _categoryRetrievalService = categoryRetrievalService;
     }

    public Task<ImportAddCommandResponse> Handle(ImportAddCommandRequest request, CancellationToken cancellationToken)
    {
        //  Get appropriate Import Template.
        var importTemplateRetrievalServiceResult = _importTemplateRetrievalService.GetById(request.ImportTemplateId);
        if (importTemplateRetrievalServiceResult.HasFailed)
        {
            return Task.FromResult(new ImportAddCommandResponse
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
