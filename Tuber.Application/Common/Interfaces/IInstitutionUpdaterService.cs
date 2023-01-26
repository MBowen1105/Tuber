using Tuber.Domain.Models;

namespace Tuber.Application.Common.Interfaces;
public interface IInstitutionUpdaterService
{
    ServiceResult<Institution> Add(string name, int orderBy);
    ServiceResult<Institution> Update(Guid institutionId, string name, int orderBy);
}
