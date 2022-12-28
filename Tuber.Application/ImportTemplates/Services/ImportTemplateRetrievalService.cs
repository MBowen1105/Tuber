using Tuber.Application.Common;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Exceptions;
using Tuber.Application.Models;

namespace Tuber.Application.ImportTemplates.Services;

public class ImportTemplateRetrievalService : IImportTemplateRetrievalService
{
    private readonly IImportTemplateRepository _importTemplateRepository;

    public ImportTemplateRetrievalService(IImportTemplateRepository importTemplateRepository)
    {
        _importTemplateRepository = importTemplateRepository;
    }

    public int CountPages(int pageSize)
    {
        return _importTemplateRepository.CountPages(pageSize);
    }

    public ServiceResult<ImportTemplate> GetById(Guid id)
    {
        var importTemplate = _importTemplateRepository.GetById(id);

        if (importTemplate.ImportTemplateId == Guid.Empty)
            return new ServiceResult<ImportTemplate>(
                importTemplate, 
                new EntityDoesNotExistException(ImportTemplate.FriendlyName, id));

        return new ServiceResult<ImportTemplate>(payload: importTemplate);
    }

    public ServiceResult<List<ImportTemplate>> GetPaged(int pageNumber, int pageSize)
    {
        var importTemplateList = _importTemplateRepository.GetPaged(pageNumber, pageSize);

        return new ServiceResult<List<ImportTemplate>>(
            payload: importTemplateList);
    }
}
