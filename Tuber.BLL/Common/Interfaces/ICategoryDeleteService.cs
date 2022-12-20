using Tuber.Domain.Common;

namespace Tuber.Application.Common.Interfaces;
public interface ICategoryDeletionService
{
    ServiceResult<int> Delete(Guid categoryId);
}
