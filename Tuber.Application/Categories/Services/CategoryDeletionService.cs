﻿using Tuber.Application.Common;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Exceptions;
using Tuber.Application.Models;

namespace Tuber.Application.Categories.Services;
public class CategoryDeletionService : ICategoryDeletionService
{
    private readonly ICategoryRepository _categoryRepo;

    public CategoryDeletionService(ICategoryRepository categoryRepo)
    {
        _categoryRepo = categoryRepo;
    }

    public ServiceResult<Category> Add(string categoryName)
    {
        var category = new Category
        {
            CategoryName = categoryName,
        };

        category = _categoryRepo.Add(category);

        if (category.CategoryId == Guid.Empty)
            return new ServiceResult<Category>(
               payload: category,
               exception: new EntityAlreadyExistsException(
                   entityName: "Category",
                   columnName: "Name", 
                   key: category.CategoryName));

        _categoryRepo.SaveChanges();

        return new ServiceResult<Category>(payload: category);
    }

    public ServiceResult<int> Delete(Guid categoryId)
    {
        var categoryModel = _categoryRepo.GetById(categoryId);

        if (categoryModel.CategoryId == Guid.Empty)
            return new ServiceResult<int>(0);

        var result = _categoryRepo.Delete(categoryId);

        _categoryRepo.SaveChanges();

        return new ServiceResult<int>(result);
    }

    public ServiceResult<Category> Update(Guid id, string categoryName)
    {
        var category = new Category
        {
            CategoryId = id,
            CategoryName = categoryName
        };

        category = _categoryRepo.Update(category);

        _categoryRepo.SaveChanges();

        return new ServiceResult<Category>(category);
    }
}
