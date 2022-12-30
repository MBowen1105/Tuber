using AutoMapper;
using Tuber.Application.ImportTemplates.Queries.ImportTemplateGetById;
using Tuber.Application.ImportTemplates.Queries.ImportTemplateGetPaged;
using Tuber.Application.Dtos;
using Tuber.Domain.Models;

namespace Tuber.Application.ImportTemplates;
public class ImportTemplateProfile : Profile
{
    public ImportTemplateProfile()
    {
        //  ImportTemplateGetById
        CreateMap<ImportTemplate, ImportTemplateGetByIdQueryResponse>()
            .ForMember(dest => dest.Exceptions, act => act.Ignore());
        CreateMap<ImportTemplateGetByIdQueryResponse, ImportTemplateGetByIdAPIResponse>();
        
        //  ImportTemplateGetPaged
        CreateMap<ImportTemplateGetPagedQueryResponse, ImportTemplateGetPagedAPIResponse>();
        CreateMap<ImportTemplate, ImportTemplateGetPaged_ImportTemplate>();

        //  ImportTemplateAdd
        //  ImportTemplateUpdate
        //  ImportTemplateDelete
    }
}
