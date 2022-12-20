using Tuber.Domain.Common;

namespace Tuber.Application.Common.Interfaces;
public interface IBankAccountDeletionService
{
    ServiceResult<int> Delete(Guid bankAccountId);
}
