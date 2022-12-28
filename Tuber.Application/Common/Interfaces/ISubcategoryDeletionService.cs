namespace Tuber.Application.Common.Interfaces;
public interface ISubcategoryDeletionService
{
    ServiceResult<int> Delete(Guid subcategoryId);
}
