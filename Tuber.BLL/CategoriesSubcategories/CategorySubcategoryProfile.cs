using AutoMapper;
using Tuber.BLL.CategoriesSubcategories.Commands.CategorySubcategoryAdd;

namespace Tuber.BLL.CategoriesSubcategories;
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
