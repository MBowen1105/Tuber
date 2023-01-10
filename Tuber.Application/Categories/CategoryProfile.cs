using AutoMapper;
using Tuber.Application.Categories.Commands.CategoryAdd;
using Tuber.Application.Categories.Commands.CategoryUpdate;
using Tuber.Application.Categories.Queries.CategoriesGetPaged;
using Tuber.Application.Categories.Queries.CategoryGetById;
using Tuber.Application.Categorys.Queries.CategoryGetById;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.Application.Categories;
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
