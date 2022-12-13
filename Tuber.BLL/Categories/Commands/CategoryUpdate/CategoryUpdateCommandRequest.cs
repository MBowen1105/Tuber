﻿using MediatR;

namespace Tuber.BLL.Categories.Commands.CategoryUpdate;
public class CategoryUpdateCommandRequest : IRequest<CategoryUpdateCommandResponse>
{
    public Guid CategoryId { get; set; }
    public string CategoryName { get; set; } = "";
}
