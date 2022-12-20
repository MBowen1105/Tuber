using Tuber.Domain.Common;

namespace Tuber.BLL.Interfaces;
public interface ISubcategoryDeletionService
{
    ServiceResult<int> Delete(Guid subcategoryId);
}
