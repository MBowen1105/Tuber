﻿using AutoMapper;
using Tuber.BLL.Categories.Commands.AddCategory;
using Tuber.BLL.Categories.Commands.UpdateCategory;
using Tuber.BLL.Categories.Queries.GetCategoriesPaged;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.BLL.Categories;
public class CategoryProfile : Profile
{
    public CategoryProfile()
    {
        CreateMap<GetCategoriesPagedQueryResponse, GetCategoriesPagedAPIResponse>();
        CreateMap<Category, GetCategoriesPaged_Category>();

        CreateMap<AddCategoryAPIRequest, AddCategoryCommandRequest>();
        CreateMap<AddCategoryCommandResponse, AddCategoryAPIResponse>();

        CreateMap<UpdateCategoryAPIRequest, UpdateCategoryCommandRequest>();
        CreateMap<UpdateCategoryCommandResponse, UpdateCategoryAPIResponse>();
    }

}
