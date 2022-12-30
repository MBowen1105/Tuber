using Tuber.Domain.Models;

namespace Tuber.Application.Common.Interfaces;
public interface IBankRetrievalService
{
    ServiceResult<Bank> GetById(Guid bankId);
    ServiceResult<List<Bank>> GetPaged(int pageNumber, int pageSize);
    int CountPages(int pageSize);
}
