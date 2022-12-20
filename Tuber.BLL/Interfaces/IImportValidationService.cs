using Tuber.Domain.Common;
using Tuber.Domain.Models;

namespace Tuber.BLL.Interfaces;
public interface IImportValidationService
{
    ServiceResult<List<Import>> Validate(ImportTemplate importTemplate, Guid bankAccountid, 
        bool suggestCategorisation, string[] allRows);
}
