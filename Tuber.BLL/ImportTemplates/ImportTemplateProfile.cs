using AutoMapper;
using Tuber.BLL.ImportTemplates.Queries.GetImportTemplatePaged;
using Tuber.BLL.ImportTemplates.Queries.ImportTemplateGetById;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.BLL.ImportTemplates;
public class ImportTemplateProfile : Profile
{
    public ImportTemplateProfile()
    {
        CreateMap<ImportTemplate, ImportTemplateGetByIdQueryResponse>()
            .ForMember(dest => dest.Exceptions, act => act.Ignore());
        CreateMap<ImportTemplateGetByIdQueryResponse, ImportTemplateGetByIdAPIResponse>();
        CreateMap<GetImportTemplatePagedQueryResponse, GetImportTemplatePagedAPIResponse>();
        CreateMap<ImportTemplate, ImportTemplatePaged_ImportTemplate>();
    }
}
