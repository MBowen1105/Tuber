using AutoMapper;
using Tuber.BLL.Subcategories.Commands.SubcategoryAdd;
using Tuber.BLL.Subcategories.Queries.SubcategoriesGetPaged;
using Tuber.BLL.Subcategories.Queries.SubcategoryGetById;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.BLL.Subcategories;
public class SubcategoryProfile : Profile
{
    public SubcategoryProfile()
    {
        CreateMap<SubcategoriesGetPagedQueryResponse, SubcategoriesGetPagedAPIResponse>();
        CreateMap<Subcategory, GetSubcategoriesPaged_Subcategory>();

        //  GetSubcategoryById
        CreateMap<Subcategory, SubcategoryGetByIdQueryResponse>()
            .ForMember(dest => dest.Exceptions, act => act.Ignore());
        CreateMap<SubcategoryGetByIdQueryResponse, SubcategoryGetByIdAPIResponse>();

        //  AddSubcategory
        CreateMap<SubcategoryAddAPIRequest, SubcategoryAddCommandRequest>();
        CreateMap<SubcategoryAddCommandResponse, SubcategoryAddAPIResponse>();

        //CreateMap<UpdateSubcategoryAPIRequest, UpdateSubcategoryCommandRequest>();
        //CreateMap<UpdateSubcategoryCommandResponse, UpdateSubcategoryAPIResponse>();
    }

}
