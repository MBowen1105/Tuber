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

    public Task<ImportUpdateCommandResponse> Handle(ImportUpdateCommandRequest request, 
        CancellationToken cancellationToken)
    {
        //  Is the given combination of Category and Subcategory valid?
        var serviceResult = _categorySubcategoryRetrievalService.IsValid(
            request.CategoryId, request.SubcategoryId);

        if (serviceResult.HasFailed)
        {
            return Task.FromResult(new ImportUpdateCommandResponse
            {
                Exceptions = serviceResult.Exceptions,
            });
        }

        var importUpdaterServiceResult = _importUpdaterService.Update(
            request.ImportId,
            request.CategoryId,
            request.SubcategoryId,
            request.Notes);

        var categoryName = "Category Name";
        var subcategoryName = "Subcategory Name";

        return Task.FromResult(new ImportUpdateCommandResponse
        {
            ImportId = request.ImportId,
            DescriptionValue = importUpdaterServiceResult.Payload.DescriptionValue!,
            CategoryId = request.CategoryId,
            SubcategoryId = request.SubcategoryId,
            CategoryName = categoryName,
            SubcategoryName = subcategoryName,
            //CategoryName = serviceResult.Payload.Category!.CategoryName,
            //SubcategoryName = serviceResult.Payload.Subcategory!.SubcategoryName,
            Notes = request.Notes,
        });
    }
}
