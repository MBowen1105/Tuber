using Tuber.Domain.Common;
using Tuber.Domain.Models;

namespace Tuber.Application.Common.Interfaces;
public interface ISubcategoryRetrievalService
{
    ServiceResult<Subcategory> GetById(Guid subcategoryId);
    ServiceResult<List<Subcategory>> GetPaged(int pageNumber, int pageSize);
    int CountPages(int pageSize);
}
