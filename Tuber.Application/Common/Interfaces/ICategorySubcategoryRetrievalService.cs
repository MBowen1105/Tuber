﻿using Tuber.Application.Models;

namespace Tuber.Application.Common.Interfaces;
public interface ICategorySubcategoryRetrievalService
{
    ServiceResult<CategorySubcategory> GetById(Guid categorySubcategoryId);
}
