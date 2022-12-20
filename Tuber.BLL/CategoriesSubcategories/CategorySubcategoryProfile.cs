using AutoMapper;
using Tuber.Application.CategoriesSubcategories.Commands.CategorySubcategoryAdd;

namespace Tuber.Application.CategoriesSubcategories;
public class CategorySubcategoryProfile : Profile
{
    public CategorySubcategoryProfile()
    {

        //  CategorySubcategoryAdd
        CreateMap<CategorySubcategoryAddAPIRequest, CategorySubcategoryAddCommandRequest>();
        CreateMap<CategorySubcategoryAddCommandResponse, CategorySubcategoryAddAPIResponse>();


        //  TODO: CategorySubcategoryDelete
    }
}
