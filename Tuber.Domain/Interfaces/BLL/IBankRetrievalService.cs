using Tuber.Domain.Models;

namespace Tuber.Domain.Interfaces.BLL;
public interface IBankRetrievalService
{
    ServiceResult<Bank> GetById(Guid bankId);
    List<Bank> GetPaged(int pageNumber, int pageSize);
    int CountPages(int pageSize);
}
