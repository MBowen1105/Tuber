using Tuber.Application.Common;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Exceptions;
using Tuber.Application.Models;

namespace Tuber.Application.Subcategories.Services;
public class SubcategoryRetrievalService : ISubcategoryRetrievalService
{
    private readonly ISubcategoryRepository _subcategoryRepository;

    public SubcategoryRetrievalService(ISubcategoryRepository subcategoryRepo)
    {
        _subcategoryRepository = subcategoryRepo;
    }

    public int CountPages(int pageSize)
    {
        return _subcategoryRepository.CountPages(pageSize);
    }

    public ServiceResult<Subcategory> GetById(Guid subcategoryId)
    {
        var subcategory =  _subcategoryRepository.GetById(subcategoryId);

        if (subcategory.SubcategoryId == Guid.Empty)
            return new ServiceResult<Subcategory>(
                payload: subcategory,
                exception: new EntityDoesNotExistException(Subcategory.FriendlyName, subcategoryId));

        return new ServiceResult<Subcategory>(subcategory);
    }

    public ServiceResult<List<Subcategory>> GetPaged(int pageNumber, int pageSize)
    {
        return new ServiceResult<List<Subcategory>>(
            payload: _subcategoryRepository.GetPaged(pageNumber, pageSize));
    }
}
