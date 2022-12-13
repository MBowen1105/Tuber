using AutoMapper;
using Tuber.BLL.Imports.Commands.ImportAdd;
using Tuber.BLL.Imports.Queries.ImportGetByBankAccountId;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.BLL.Imports;
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
