using Tuber.Domain.Models;

namespace Tuber.Application.Common.Interfaces;
public interface IImportUpdaterService
{
    ServiceResult<ImportResult> Add(Guid bankAccountId, List<Import> allLines);
}
