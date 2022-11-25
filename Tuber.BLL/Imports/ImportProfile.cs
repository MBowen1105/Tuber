using AutoMapper;
using Tuber.BLL.Imports.Commands.AddImport;
using Tuber.BLL.Imports.Queries;
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

        CreateMap<Import, ImportDto>()
            .ForMember(dest => dest.ImportRowStatusDesc, opt => opt.MapFrom(src => src.ImportRowStatus.ToString()));

        CreateMap<GetImportByBankAccountIdQueryResponse, GetImportByBankAccountIdAPIResponse>();


    }

}
