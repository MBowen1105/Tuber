using Tuber.Domain.Common;
using Tuber.Domain.Models;

namespace Tuber.BLL.Interfaces;
public interface ICategoryUpdaterService
{
    ServiceResult<Category> Add(string categoryName);
    ServiceResult<Category> Update(Guid id, string categoryName);
}
