using Tuber.Domain.Common;

namespace Tuber.Domain.Interfaces.BLL;
public interface IBankDeletionService
{
    ServiceResult<int> Delete(Guid bankId);
}
