using AutoMapper;
using Tuber.BLL.Categories.Commands.CategoryAdd;
using Tuber.BLL.Categories.Commands.CategoryUpdate;
using Tuber.BLL.Categories.Queries.CategoriesGetPaged;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.BLL.Categories;
public class CategoryProfile : Profile
{
    public CategoryProfile()
    {
        //  GetCategoriesPaged
        CreateMap<CategoriesGetPagedQueryResponse, CategoriesGetPagedAPIResponse>();
        CreateMap<Category, GetCategoriesPaged_Category>();

        //  AddCategory
        CreateMap<CategoryAddAPIRequest, CategoryAddCommandRequest>();
        CreateMap<CategoryAddCommandResponse, CategoryAddAPIResponse>();

        //  UpdateCategory
        CreateMap<CategoryUpdateAPIRequest, CategoryUpdateCommandRequest>();
        CreateMap<CategoryUpdateCommandResponse, CategoryUpdateAPIResponse>();
    }

}
