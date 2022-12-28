using Tuber.Application.Models;

namespace Tuber.Application.Common.Interfaces;
public interface IImportTemplateRetrievalService
{
    ServiceResult<ImportTemplate> GetById(Guid id);
    ServiceResult<List<ImportTemplate>> GetPaged(int pageNumber, int pageSize);
    int CountPages(int pageSize);
}
