﻿using Tuber.Application.Common;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Exceptions;
using Tuber.Domain.Models;

namespace Tuber.Application.Categories.Services;
public class CategoryRetrievalService : ICategoryRetrievalService
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryRetrievalService(ICategoryRepository categoryRepo)
    {
        _categoryRepository = categoryRepo;
    }

    
    public ServiceResult<Category> GetById(Guid categoryId)
    {
        var category = _categoryRepository.GetById(categoryId);

        if (category.CategoryId == Guid.Empty)
            return new ServiceResult<Category>(
                payload: category,
                exception: new EntityDoesNotExistException(Category.FriendlyName, categoryId));

        return new ServiceResult<Category>(category);
    }

    public ServiceResult<List<Category>> GetPaged(int pageNumber, int pageSize)
    {
        return new ServiceResult<List<Category>>(
            payload: _categoryRepository.GetPaged(pageNumber, pageSize));
    }
    
    public int CountPages(int pageSize)
    {
        return _categoryRepository.CountPages(pageSize);
    }

}
