using AutoMapper;
using Tuber.Application.Imports.Commands.ImportAdd;
using Tuber.Application.Imports.Queries.ImportGetByBankAccountId;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

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

    }

}
