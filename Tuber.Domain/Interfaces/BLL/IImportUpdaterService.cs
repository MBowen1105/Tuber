using Tuber.Domain.Models;

namespace Tuber.Domain.Interfaces.BLL;
public interface IImportUpdaterService
{
    ServiceResult<ImportResult> ImportFile(Guid importTemplateId, Guid bankAccountId, string importFileName);
}
