using Tuber.Domain.Common;
using Tuber.Domain.Models;

namespace Tuber.BLL.Interfaces;
public interface IImportUpdaterService
{
    ServiceResult<ImportResult> Add(Guid bankAccountId, List<Import> allLines);
}
