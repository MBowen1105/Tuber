using Tuber.Domain.Common;

namespace Tuber.Domain.Interfaces.BLL;
public interface IBankAccountDeletionService
{
    ServiceResult<int> Delete(Guid bankAccountId);
}
