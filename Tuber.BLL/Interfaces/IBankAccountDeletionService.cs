using Tuber.Domain.Common;

namespace Tuber.BLL.Interfaces;
public interface IBankAccountDeletionService
{
    ServiceResult<int> Delete(Guid bankAccountId);
}
