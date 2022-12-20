using Tuber.Domain.Common;
using Tuber.Domain.Models;

namespace Tuber.Application.Common.Interfaces;
public interface ICategoryRetrievalService
{
    ServiceResult<Category> GetById(Guid categoryId);
    ServiceResult<List<Category>> GetPaged(int pageNumber, int pageSize);
    int CountPages(int pageSize);
}
