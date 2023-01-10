using AutoMapper;
using Tuber.Application.Imports.Commands.ImportAdd;
using Tuber.Application.Imports.Queries.ImportGetByBankAccountId;
using Tuber.Application.Dtos;
using Tuber.Domain.Models;
using Tuber.Application.Imports.Commands.ImportUpdate;
using Tuber.Application.Imports.Commands.ImportAccept;

namespace Tuber.Application.Imports;
public class ImportProfile : Profile
{
    public ImportProfile()
    {
        //  ImportGetByBankAccountId
        CreateMap<ImportGetByBankAccountIdQueryResponse, ImportGetByBankAccountIdAPIResponse>();
        CreateMap<Import, GetImportByBankAccountId_Import>()
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
