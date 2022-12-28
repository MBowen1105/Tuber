using AutoMapper;
using Tuber.Application.CategorySubcategories.Commands.AddCategorySubcategory;
using Tuber.Application.CategorySubcategories.Commands.BankAdd;
using Tuber.Application.CategorySubcategories.Commands.CategorySubcategoryAdd;
using Tuber.Application.Models;

namespace Tuber.Application.CategorySubcategorys;
public class CategorySubcategoryProfile : Profile
{
    public CategorySubcategoryProfile()
    {
        //  CategorySubcategoryGetById
        //CreateMap<CategorySubcategoryGetByIdQueryResponse, CategorySubcategoryGetByIdAPIResponse>();
        //CreateMap<CategorySubcategory, CategorySubcategoryGetByIdQueryResponse>()
        //    .ForMember(dest => dest.Exceptions, act => act.Ignore());

        //  CategorySubcategoryAdd
        CreateMap<CategorySubcategoryAddAPIRequest, CategorySubcategoryAddCommandRequest>();
        CreateMap<CategorySubcategoryAddCommandResponse, CategorySubcategoryAddAPIResponse>();

  
        //  TODO: CategorySubcategoryDelete
    }

}
