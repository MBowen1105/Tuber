using AutoMapper;
using Tuber.BLL.Imports.Commands.AddImport;
using Tuber.BLL.Imports.Queries.GetImportByBankAccountId;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.BLL.Imports;
public class ImportProfile : Profile
{
    public ImportProfile()
    {
        //  API
        CreateMap<AddImportAPIRequest, AddImportCommandRequest>();
        CreateMap<AddImportCommandResponse, AddImportAPIResponse>();

        CreateMap<Import, GetImportByBankAccountId_Import>()
            .ForMember(dest => dest.ImportRowStatusDesc, opt => opt.MapFrom(src => src.ImportRowStatus.ToString()));

        CreateMap<GetImportByBankAccountIdQueryResponse, GetImportByBankAccountIdAPIResponse>();
    }

}
