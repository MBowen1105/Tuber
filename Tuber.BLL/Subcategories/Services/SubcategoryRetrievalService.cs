using Tuber.Application.Common.Interfaces;
using Tuber.Core.Enums;
using Tuber.Domain.Common;
using Tuber.Domain.Exceptions;
using Tuber.Domain.Models;

namespace Tuber.Application.Subcategories.Services;
public class SubcategoryRetrievalService : ISubcategoryRetrievalService
{
    private readonly ISubcategoryRepository _subcategoryRepository;

    public SubcategoryRetrievalService(ISubcategoryRepository subcategoryRepo)
    {
        _subcategoryRepository = subcategoryRepo;
    }
    
    public ServiceResult<Subcategory> GetById(Guid subcategoryId)
    {
        var subcategory =  _subcategoryRepository.GetById(subcategoryId);

        if (subcategory.SubcategoryId == Guid.Empty)
            return new ServiceResult<Subcategory>(
                payload: subcategory,
                exception: new EntityDoesNotExistException(
                    ExceptionDbOperation.Get, Subcategory.FriendlyName, subcategoryId));

        return new ServiceResult<Subcategory>(subcategory);
    }

    public ServiceResult<List<Subcategory>> GetPaged(int pageNumber, int pageSize)
    {
        return new ServiceResult<List<Subcategory>>(
            payload: _subcategoryRepository.GetPaged(pageNumber, pageSize));
    }

    public int CountPages(int pageSize)
    {
        return _subcategoryRepository.CountPages(pageSize);
    }
}
