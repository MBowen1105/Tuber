using Tuber.Domain.Common;
using Tuber.Domain.Models;

namespace Tuber.BLL.Interfaces;
public interface ISubcategoryRetrievalService
{
    ServiceResult<Subcategory> GetById(Guid subcategoryId);
    ServiceResult<List<Subcategory>> GetPaged(int pageNumber, int pageSize);
    int CountPages(int pageSize);
}
