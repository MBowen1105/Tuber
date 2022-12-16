using Tuber.Domain.Common;

namespace Tuber.Domain.Interfaces.BLL;
public interface ISubcategoryDeletionService
{
    ServiceResult<int> Delete(Guid subcategoryId);
}
