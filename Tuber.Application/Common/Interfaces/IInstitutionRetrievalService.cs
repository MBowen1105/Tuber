using Tuber.Domain.Models;

namespace Tuber.Application.Common.Interfaces;
public interface IInstitutionRetrievalService
{
    ServiceResult<Institution> GetById(Guid institutionId);
    ServiceResult<List<Institution>> GetPaged(int pageNumber, int pageSize);
    int CountPages(int pageSize);
}
