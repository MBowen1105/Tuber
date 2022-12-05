using Tuber.Domain.Models;

namespace Tuber.Domain.Interfaces.BLL;
public interface IImportValidationService
{
    ServiceResult<List<Import>> Validate(ImportTemplate importTemplate, Guid bankAccountid, 
        bool suggestCategorisation, string[] allRows);
}
