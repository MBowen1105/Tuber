using AutoMapper;
using Tuber.BLL.Subcategories.Queries.GetSubcategoriesPaged;
using Tuber.BLL.Subcategories.Commands.AddCategory;
using Tuber.BLL.Subcategories.Commands.AddSubcategory;
using Tuber.BLL.Subcategories.Queries.GetSubcategoriesPaged;
using Tuber.BLL.Subcategories.Queries.GetSubcategoryById;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.BLL.Subcategories;
public class SubcategoryProfile : Profile
{
    public SubcategoryProfile()
    {
        CreateMap<GetSubcategoriesPagedQueryResponse, GetSubcategoriesPagedAPIResponse>();
        CreateMap<Subcategory, GetSubcategoriesPaged_Subcategory>();

        //  GetSubcategoryById
        CreateMap<Subcategory, GetSubcategoryByIdQueryResponse>()
            .ForMember(dest => dest.Exceptions, act => act.Ignore());
        CreateMap<GetSubcategoryByIdQueryResponse, GetSubcategoryByIdAPIResponse>();

        //  AddSubcategory
        CreateMap<AddSubcategoryAPIRequest, AddSubcategoryCommandRequest>();
        CreateMap<AddSubcategoryCommandResponse, AddSubcategoryAPIResponse>();

        //CreateMap<UpdateSubcategoryAPIRequest, UpdateSubcategoryCommandRequest>();
        //CreateMap<UpdateSubcategoryCommandResponse, UpdateSubcategoryAPIResponse>();
    }

}
