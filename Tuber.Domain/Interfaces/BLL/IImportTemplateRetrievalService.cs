using Tuber.Domain.Models;

namespace Tuber.Domain.Interfaces.BLL;
public interface IImportTemplateRetrievalService
{
    ServiceResult<ImportTemplate> GetById(Guid id);
}
