using Tuber.Domain.Models;

namespace Tuber.Domain.Interfaces.BLL;
public interface IImportUpdaterService
{
    ServiceResult<ImportResult> Load(Guid bankAccountId, List<Import> allLines);
}
