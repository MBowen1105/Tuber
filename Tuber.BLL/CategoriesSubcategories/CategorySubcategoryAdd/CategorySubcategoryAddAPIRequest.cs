﻿namespace Tuber.Application.CategoriesSubcategories.Commands.CategorySubcategoryAdd;
public class CategorySubcategoryAddAPIRequest
{
    public Guid CategoryId { get; set; }
    public Guid? SubcategoryId { get; set; }
}
