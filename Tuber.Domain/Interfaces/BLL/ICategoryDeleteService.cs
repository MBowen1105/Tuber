using Tuber.Domain.Common;

namespace Tuber.Domain.Interfaces.BLL;
public interface ICategoryDeletionService
{
    ServiceResult<int> Delete(Guid categoryId);
}
