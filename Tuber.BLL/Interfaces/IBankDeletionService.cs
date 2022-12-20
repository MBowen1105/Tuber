using Tuber.Domain.Common;

namespace Tuber.BLL.Interfaces;
public interface IBankDeletionService
{
    ServiceResult<int> Delete(Guid bankId);
}
