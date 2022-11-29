using Tuber.Domain.Models;

namespace Tuber.Domain.Interfaces.BLL;
public interface IImportUpdaterService
{
    ServiceResult<ImportResult> Add(Guid bankAccountId, List<Import> allLines);
}
