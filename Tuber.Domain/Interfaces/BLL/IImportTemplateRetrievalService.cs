using Tuber.Domain.Common;
using Tuber.Domain.Models;

namespace Tuber.Domain.Interfaces.BLL;
public interface IImportTemplateRetrievalService
{
    ServiceResult<ImportTemplate> GetById(Guid id);
    ServiceResult<List<ImportTemplate>> GetPaged(int pageNumber, int pageSize);
    int CountPages(int pageSize);
}
