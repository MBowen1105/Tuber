using AutoMapper;
using Tuber.BLL.Categories.Commands.CategoryAdd;
using Tuber.BLL.Categories.Commands.CategoryUpdate;
using Tuber.BLL.Categories.Queries.CategoriesGetPaged;
using Tuber.BLL.Categories.Queries.CategoryGetById;
using Tuber.BLL.Categorys.Queries.CategoryGetById;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.BLL.Categories;
public class CategoryProfile : Profile
{
    public CategoryProfile()
    {
        //  CategoryGetById
        CreateMap<Category, CategoryGetByIdQueryResponse>()
            .ForMember(dest => dest.Exceptions, act => act.Ignore());
        CreateMap<CategoryGetByIdQueryResponse, CategoryGetByIdAPIResponse>();

        //  CategoriesGetPaged
        CreateMap<CategoriesGetPagedQueryResponse, CategoriesGetPagedAPIResponse>();
        CreateMap<Category, GetCategoriesPaged_Category>();

        //  CategoryAdd
        CreateMap<CategoryAddAPIRequest, CategoryAddCommandRequest>();
        CreateMap<CategoryAddCommandResponse, CategoryAddAPIResponse>();

        //  CategoryUpdate
        CreateMap<CategoryUpdateAPIRequest, CategoryUpdateCommandRequest>();
        CreateMap<CategoryUpdateCommandResponse, CategoryUpdateAPIResponse>();

        //  TODO: CategoryDelete
    }
}
