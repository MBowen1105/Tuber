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

    public ServiceResult<ImportTemplate> GetById(Guid id)
    {
        var importTemplate = _importTemplateRepository.GetById(id);

        if (importTemplate.ImportTemplateId == Guid.Empty)
            return new ServiceResult<ImportTemplate>(
                importTemplate, 
                new ImportTemplateDoesNotExistException(id));

        return new ServiceResult<ImportTemplate>(payload: importTemplate);
    }
}
