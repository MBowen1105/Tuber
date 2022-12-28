using Tuber.Application.Models;

namespace Tuber.Application.Common.Interfaces;
public interface ISubcategoryUpdaterService
{
    ServiceResult<Subcategory> Add(string subcategoryName);
    ServiceResult<Subcategory> Update(Guid subcategoryId, string subcategoryName);
}
