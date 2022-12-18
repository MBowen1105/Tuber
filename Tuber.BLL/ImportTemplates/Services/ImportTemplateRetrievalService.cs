using Tuber.Core.Enums;
using Tuber.Domain.Common;
using Tuber.Domain.Exceptions;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Models;

namespace Tuber.BLL.ImportTemplates.Services;

public class ImportTemplateRetrievalService : IImportTemplateRetrievalService
{
    private readonly IImportTemplateRepository _importTemplateRepository;

    public ImportTemplateRetrievalService(IImportTemplateRepository importTemplateRepository)
    {
        _importTemplateRepository = importTemplateRepository;
    }

    public ServiceResult<ImportTemplate> GetById(Guid importTemplateId)
    {
        var importTemplate = _importTemplateRepository.GetById(importTemplateId);

        if (importTemplate.ImportTemplateId == Guid.Empty)
            return new ServiceResult<ImportTemplate>(
                importTemplate, 
                new EntityDoesNotExistException(ExceptionDbOperation.Get, ImportTemplate.FriendlyName, importTemplateId));

        return new ServiceResult<ImportTemplate>(payload: importTemplate);
    }

    public ServiceResult<List<ImportTemplate>> GetPaged(int pageNumber, int pageSize)
    {
        var importTemplateList = _importTemplateRepository.GetPaged(pageNumber, pageSize);

        return new ServiceResult<List<ImportTemplate>>(
            payload: importTemplateList);
    }

    public int CountPages(int pageSize)
    {
        return _importTemplateRepository.CountPages(pageSize);
    }

}
