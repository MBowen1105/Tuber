using AutoMapper;
using Tuber.Application.Institutions.Commands.InstitutionAdd;
using Tuber.Application.Institutions.Commands.InstitutionUpdate;
using Tuber.Application.Institutions.Queries.InstitutionGetById;
using Tuber.Application.Institutions.Queries.InstitutionGetPaged;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.Application.Institutions;
public class InstitutionProfile : Profile
{
    public InstitutionProfile()
    {
        //  InstitutionGetById
        CreateMap<InstitutionGetByIdQueryResponse, InstitutionGetByIdAPIResponse>();

        CreateMap<Institution, InstitutionGetByIdQueryResponse>()
            .ForMember(dest => dest.Exceptions, act => act.Ignore());

        //  InstitutionsGetPaged
        CreateMap<InstitutionGetPagedQueryResponse, InstitutionGetPagedAPIResponse>();
        CreateMap<Institution, InstitutionGetPaged_Institution>();

        //  InstitutionAdd
        CreateMap<InstitutionAddAPIRequest, InstitutionAddCommandRequest>();
        CreateMap<InstitutionAddCommandResponse, InstitutionAddAPIResponse>();

        //  InstitutionUpdate
        CreateMap<InstitutionUpdateAPIRequest, InstitutionUpdateCommandRequest>();
        CreateMap<InstitutionUpdateCommandResponse, InstitutionUpdateAPIResponse>();

        //  TODO: InstitutionDelete

        //  WTF are these?
        CreateMap<ImportTemplate, InstitutionGetById_ImportTemplate>();
        CreateMap<InstitutionAccount, InstitutionGetById_InstitutionAccount>();
        CreateMap<InstitutionAccount, InstitutionGetPaged_InstitutionAccount>();
    }
}
