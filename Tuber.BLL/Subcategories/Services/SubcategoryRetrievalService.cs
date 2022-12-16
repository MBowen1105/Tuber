﻿using Tuber.Domain.Common;
using Tuber.Domain.Exceptions;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Models;

namespace Tuber.BLL.Subcategories.Services;
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
                exception: new EntityDoesNotExistException(Subcategory.FriendlyName, subcategoryId));

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
