using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Models;

namespace Tuber.BLL.Categories.Services;
public class CategoryRetrievalService : ICategoryRetrievalService
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryRetrievalService(ICategoryRepository categoryRepo)
    {
        _categoryRepository = categoryRepo;
    }

    public int CountPages(int pageSize)
    {
        return _categoryRepository.CountPages(pageSize);
    }

    public ServiceResult<List<Category>> GetPaged(int pageNumber, int pageSize)
    {
        return new ServiceResult<List<Category>>(
            payload: _categoryRepository.GetPaged(pageNumber, pageSize));
    }
}
