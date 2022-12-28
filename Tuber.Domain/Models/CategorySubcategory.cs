﻿namespace Tuber.Application.Models;
public class CategorySubcategory
{
    public static readonly string FriendlyName = "Category/Subcategory";

    public Guid CategorySubcategoryId { get; set; }
    public Guid CategoryId { get; set; }
    public Guid? SubcategoryId { get; set; }
    public virtual Category? Category { get; set; }
    public virtual Subcategory? Subcategory { get; set; }
    public bool IsCoreCategorySubcategory { get; set; }
    public bool IsDeleted { get; set; }

    public string ShortName => $"{Category?.CategoryName}/{Subcategory?.SubcategoryName}".TrimEnd('/');
}
