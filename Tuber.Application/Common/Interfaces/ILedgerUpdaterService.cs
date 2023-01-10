using Tuber.Domain.Common;
using Tuber.Domain.Models;

namespace Tuber.Application.Common.Interfaces;
public interface ILedgerUpdaterService
{
    ServiceResult<AcceptResult> Accept(Guid bankAccountId, List<Import> imports);
}
