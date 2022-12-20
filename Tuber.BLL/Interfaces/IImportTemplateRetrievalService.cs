using Tuber.Domain.Common;
using Tuber.Domain.Models;

namespace Tuber.BLL.Interfaces;
public interface IImportTemplateRetrievalService
{
    ServiceResult<ImportTemplate> GetById(Guid id);
    ServiceResult<List<ImportTemplate>> GetPaged(int pageNumber, int pageSize);
    int CountPages(int pageSize);
}
