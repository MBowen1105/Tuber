using Tuber.Domain.Common;
using Tuber.Domain.Models;

namespace Tuber.Domain.Interfaces.BLL;
public interface ICategoryRetrievalService
{
    ServiceResult<Category> GetById(Guid categoryId);
    ServiceResult<List<Category>> GetPaged(int pageNumber, int pageSize);
    int CountPages(int pageSize);
}
