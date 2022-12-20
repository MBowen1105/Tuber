﻿using Tuber.Application.Common.Interfaces;
using Tuber.Domain.Common;
using Tuber.Domain.Models;

namespace Tuber.Application.CategoriesSubcategories.Services;
public class CategorySubcategoryUpdaterService : ICategorySubcategoryUpdaterService
{
    private readonly ICategorySubcategoryRepository _categorySubcategoryRepo;

    public CategorySubcategoryUpdaterService(ICategorySubcategoryRepository categorySubcategoryRepo)
    {
        _categorySubcategoryRepo = categorySubcategoryRepo;
    }

    public ServiceResult<CategorySubcategory> Add(Guid categoryId, Guid? subcategoryId)
    {
        var categorySubcategory = new CategorySubcategory
        {
            CategoryId = categoryId,
            SubcategoryId = subcategoryId
        };

        categorySubcategory = _categorySubcategoryRepo.Add(categorySubcategory);

        _categorySubcategoryRepo.SaveChanges();

        return new ServiceResult<CategorySubcategory>(categorySubcategory);
    }
}
