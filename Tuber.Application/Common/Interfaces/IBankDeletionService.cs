namespace Tuber.Application.Common.Interfaces;
public interface IBankDeletionService
{
    ServiceResult<int> Delete(Guid bankId);
}
