using AutoMapper;
using Tuber.Application.CategorySubcategories.Commands.AddCategorySubcategory;
using Tuber.Application.CategorySubcategories.Commands.BankAdd;
using Tuber.Application.CategorySubcategories.Commands.CategorySubcategoryAdd;
using Tuber.Application.CategorySubcategories.Queries.CategorySubcategoryGetById;
using Tuber.Domain.Models;

namespace Tuber.Application.CategorySubcategorys;
public class CategorySubcategoryProfile : Profile
{
    public CategorySubcategoryProfile()
    {
        //  CategorySubcategoryGetById

        CreateMap<CategorySubcategory, CategorySubcategoryGetByIdQueryResponse>()
            .ForMember(dest => dest.Exceptions, act => act.Ignore())
            .ForMember(dest => dest.ShortName, act => act.Ignore());
        CreateMap<CategorySubcategoryGetByIdQueryResponse, CategorySubcategoryGetByIdAPIResponse>();

        //  CategorySubcategoryAdd
        CreateMap<CategorySubcategoryAddAPIRequest, CategorySubcategoryAddCommandRequest>();
        CreateMap<CategorySubcategoryAddCommandResponse, CategorySubcategoryAddAPIResponse>();


        //  TODO: CategorySubcategoryDelete
    }

}
