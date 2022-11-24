using Tuber.Domain.Models;

namespace Tuber.Domain.Interfaces.BLL;
public interface IImportUpdaterService
{
    ImportResult Import(Guid importTemplateId, Guid bankAccountId, string importFileName);
}
