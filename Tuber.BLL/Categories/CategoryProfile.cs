using AutoMapper;
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
        //  GetCategoriesPaged
        CreateMap<GetCategoriesPagedQueryResponse, GetCategoriesPagedAPIResponse>();
        CreateMap<Category, GetCategoriesPaged_Category>();

        //  AddCategory
        CreateMap<AddCategoryAPIRequest, AddCategoryCommandRequest>();
        CreateMap<AddCategoryCommandResponse, AddCategoryAPIResponse>();

        //  UpdateCategory
        CreateMap<UpdateCategoryAPIRequest, UpdateCategoryCommandRequest>();
        CreateMap<UpdateCategoryCommandResponse, UpdateCategoryAPIResponse>();
    }

}
