using Tuber.Domain.Common;
using Tuber.Domain.Models;

namespace Tuber.Domain.Interfaces.BLL;
public interface ISubcategoryUpdaterService
{
    ServiceResult<Subcategory> Add(string subcategoryName);
    ServiceResult<Subcategory> Update(Guid subcategoryId, string subcategoryName);
}
