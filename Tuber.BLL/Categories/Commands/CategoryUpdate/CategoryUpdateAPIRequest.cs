﻿namespace Tuber.Application.Categories.Commands.CategoryUpdate;
public class CategoryUpdateAPIRequest
{
    public Guid CategoryId { get; set; }

    public string CategoryName { get; set; } = "";
}
