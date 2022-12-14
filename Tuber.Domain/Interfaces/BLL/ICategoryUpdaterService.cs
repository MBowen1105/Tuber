using Tuber.Domain.Common;
using Tuber.Domain.Models;

namespace Tuber.Domain.Interfaces.BLL;
public interface ICategoryUpdaterService
{
    ServiceResult<Category> Add(string categoryName);
    ServiceResult<Category> Update(Guid id, string categoryName);
    ServiceResult<int> Delete(Guid categoryId);
}
