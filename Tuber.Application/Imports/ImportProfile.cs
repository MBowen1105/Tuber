using AutoMapper;
using Tuber.Application.Imports.Commands.ImportAccept;
using Tuber.Application.Imports.Commands.ImportAdd;
using Tuber.Application.Imports.Commands.ImportUpdate;
using Tuber.Application.Imports.Queries.ImportGetByInstitutionAccountId;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.Application.Imports;
public class ImportProfile : Profile
{
    public ImportProfile()
    {
        //  ImportGetByInstitutionAccountId
        CreateMap<ImportGetByInstitutionAccountIdQueryResponse, ImportGetByInstitutionAccountIdAPIResponse>();
        CreateMap<Import, GetImportByInstitutionAccountId_Import>()
            .ForMember(dest => dest.ImportRowStatusDesc, opt => opt.MapFrom(src => src.ImportRowStatus.ToString()));

        //  ImportAdd
        CreateMap<ImportAddAPIRequest, ImportAddCommandRequest>();
        CreateMap<ImportAddCommandResponse, ImportAddAPIResponse>();

        //  ImportUpdate
        CreateMap<ImportUpdateAPIRequest, ImportUpdateCommandRequest>();

        CreateMap<ImportUpdateCommandResponse, ImportUpdateAPIResponse>();


        //  ImportAccept
        CreateMap<ImportAcceptCommandResponse, ImportAcceptAPIResponse>();
    }

}
