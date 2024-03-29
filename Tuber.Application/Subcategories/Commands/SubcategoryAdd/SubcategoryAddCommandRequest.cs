﻿using MediatR;

namespace Tuber.Application.Subcategories.Commands.SubcategoryAdd;
public class SubcategoryAddCommandRequest : IRequest<SubcategoryAddCommandResponse>
{
    public string SubcategoryName { get; set; } = "";
    public Guid CategoryId { get; set; }
}
