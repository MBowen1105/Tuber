using Tuber.Domain.Common;

namespace Tuber.BLL.Interfaces;
public interface ICategoryDeletionService
{
    ServiceResult<int> Delete(Guid categoryId);
}
