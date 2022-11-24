using AutoMapper;
using Tuber.BLL.Imports.Commands.AddImport;
using Tuber.Domain.Models;

namespace Tuber.BLL.Imports;
public class ImportProfile : Profile
{
    public ImportProfile()
    {
        //  API
        CreateMap<AddImportAPIRequest, AddImportCommandRequest>();
        CreateMap<AddImportCommandResponse, AddImportAPIResponse>();

        

        //CreateMap<GetImportPagedQueryResponse, GetImportPagedAPIResponse>();

        //CreateMap<Import, ImportDto>();
    }

}
