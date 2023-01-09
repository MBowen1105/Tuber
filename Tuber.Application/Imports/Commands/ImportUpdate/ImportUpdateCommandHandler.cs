using MediatR;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.FileSystem;
using Tuber.Application.Exceptions;

namespace Tuber.Application.Imports.Commands.ImportUpdate;

public class ImportUpdateCommandHandler : IRequestHandler<ImportUpdateCommandRequest, ImportUpdateCommandResponse>
{
    private readonly IImportUpdaterService _importUpdaterService;
    private readonly ICategorySubcategoryRetrievalService _categorySubcategoryRetrievalService;

    public ImportUpdateCommandHandler(
        IImportUpdaterService importUpdaterService,
        ICategorySubcategoryRetrievalService categorySubcategoryRetrievalService)
    {
        _importUpdaterService = importUpdaterService;
        _categorySubcategoryRetrievalService = categorySubcategoryRetrievalService;
    }

    public Task<ImportUpdateCommandResponse> Handle(ImportUpdateCommandRequest request, CancellationToken cancellationToken)
    {
        //  Does the given CategorySubcategoryId exist?
        var serviceResult = _categorySubcategoryRetrievalService.GetById(request.CategorySubcategoryId);
        if (serviceResult.HasFailed)
        {
            return Task.FromResult(new ImportUpdateCommandResponse
            {
                Exceptions = serviceResult.Exceptions,
            });
        }

        var importUpdaterServiceResult = _importUpdaterService.Update(
            request.ImportId,
            request.CategorySubcategoryId,
            request.Notes);

        return Task.FromResult(new ImportUpdateCommandResponse
        {
            ImportId = request.ImportId,
            DescriptionValue = importUpdaterServiceResult.Payload.DescriptionValue!,
            CategorySubcategoryId = request.CategorySubcategoryId,
            CategoryName = serviceResult.Payload.Category!.CategoryName,
            SubcategoryName = serviceResult.Payload.Subcategory!.SubcategoryName,
            Notes = request.Notes,
        });
    }
}
