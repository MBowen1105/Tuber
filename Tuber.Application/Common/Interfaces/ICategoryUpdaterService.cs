using Tuber.Domain.Models;

namespace Tuber.Application.Common.Interfaces;
public interface ICategoryUpdaterService
{
    ServiceResult<Category> Add(string categoryName);
    ServiceResult<Category> Update(Guid id, string categoryName);
}
