using AutoMapper;
using Tuber.Application.Imports.Commands.ImportAccept;
using Tuber.Application.Imports.Commands.ImportAdd;
using Tuber.Application.Imports.Commands.ImportUpdate;
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
            .ForMember(dest => dest.BankAccountName, opt => opt.Ignore())
            .ForMember(dest => dest.ImportRowStatusDesc, opt => opt.MapFrom(src => src.ImportRowStatus.ToString()))
            .ForMember(dest => dest.CategoryShortName, opt => opt.Ignore())
            .ForMember(dest => dest.SubcategoryShortName, opt => opt.Ignore())
            .ForMember(dest => dest.ImportedByUserFullName, opt => opt.Ignore());

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
