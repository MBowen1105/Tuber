using AutoMapper;
using Tuber.BLL.Subcategories.Commands.AddCategory;
using Tuber.BLL.Subcategories.Commands.AddSubcategory;

namespace Tuber.BLL.Subcategories;
public class SubcategoryProfile : Profile
{
    public SubcategoryProfile()
    {
        //CreateMap<GetSubcategoriesPagedQueryResponse, GetSubcategoriesPagedAPIResponse>();
        //CreateMap<Subcategory, GetSubcategoriesPaged_Subcategory>();

        CreateMap<AddSubcategoryAPIRequest, AddSubcategoryCommandRequest>();
        CreateMap<AddSubcategoryCommandResponse, AddSubcategoryAPIResponse>();

        //CreateMap<UpdateSubcategoryAPIRequest, UpdateSubcategoryCommandRequest>();
        //CreateMap<UpdateSubcategoryCommandResponse, UpdateSubcategoryAPIResponse>();
    }

}
