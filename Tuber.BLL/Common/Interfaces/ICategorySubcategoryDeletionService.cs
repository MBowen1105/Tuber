using Tuber.Domain.Common;

namespace Tuber.Application.Common.Interfaces;
public interface ICategorySubcategoryDeletionService
{
    ServiceResult<int> Delete(Guid categorySubcategoryId);
}