using AutoMapper;
using Tuber.Application.Subcategories.Commands.SubcategoryAdd;
using Tuber.Application.Subcategories.Commands.SubcategoryUpdate;
using Tuber.Application.Subcategories.Queries.SubcategoriesGetPaged;
using Tuber.Application.Subcategories.Queries.SubcategoryGetById;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.Application.Subcategories;
public class SubcategoryProfile : Profile
{
    public SubcategoryProfile()
    {
        //  SubcategoryGetById
        CreateMap<Subcategory, SubcategoryGetByIdQueryResponse>()
            .ForMember(dest => dest.Exceptions, act => act.Ignore());
        CreateMap<SubcategoryGetByIdQueryResponse, SubcategoryGetByIdAPIResponse>();

        //  SubcategoriesGetPaged
        CreateMap<SubcategoriesGetPagedQueryResponse, SubcategoriesGetPagedAPIResponse>();
        CreateMap<Subcategory, GetSubcategoriesPaged_Subcategory>();

        //  SubcategoryAdd
        CreateMap<SubcategoryAddAPIRequest, SubcategoryAddCommandRequest>();
        CreateMap<SubcategoryAddCommandResponse, SubcategoryAddAPIResponse>();

        //  SubcategoryUpdate
        CreateMap<SubcategoryUpdateAPIRequest, SubcategoryUpdateCommandRequest>();
        CreateMap<SubcategoryUpdateCommandResponse, SubcategoryUpdateAPIResponse>();
    }

}
