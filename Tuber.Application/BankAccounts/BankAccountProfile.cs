using AutoMapper;
using Tuber.Application.InstitutionAccounts.Queries.InstitutionAccountGetById;
using Tuber.Application.InstitutionAccounts.Queries.InstitutionAccountGetPaged;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.Application.InstitutionAccounts;
public class InstitutionAccountProfile : Profile
{
    public InstitutionAccountProfile()
    {
        //  InstitutionAccountGetById
        CreateMap<InstitutionAccountGetByIdQueryResponse, InstitutionAccountGetByIdAPIResponse>();
        CreateMap<InstitutionAccount, InstitutionAccountGetByIdQueryResponse>()
            .ForMember(dest => dest.Exceptions, act => act.Ignore());

        //  InstitutionsGetPaged
        CreateMap<InstitutionAccountGetPagedQueryResponse, InstitutionAccountGetPagedAPIResponse>();
        CreateMap<InstitutionAccount, InstitutionAccountGetPaged_InstitutionAccount>();

        //  TODO: InstitutionAccountAdd
        //  TODO: InstitutionAccountUpdate
        //  TODO: InstitutionAccountDelete
    }

}
