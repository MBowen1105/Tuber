using AutoMapper;
using Tuber.BLL.ImportTemplates.Queries.GetImportTemplateById;
using Tuber.BLL.ImportTemplates.Queries.GetImportTemplatePaged;
using Tuber.Domain.Dtos;
using Tuber.Domain.Models;

namespace Tuber.BLL.ImportTemplates;
public class ImportTemplateProfile : Profile
{
    public ImportTemplateProfile()
    {
        CreateMap<ImportTemplate, GetImportTemplateByIdQueryResponse>()
            .ForMember(dest => dest.Exceptions, act => act.Ignore());
        CreateMap<ImportTemplate, ImportTemplateDto>();
        CreateMap<GetImportTemplateByIdQueryResponse, GetImportTemplateByIdAPIResponse>();
        CreateMap<GetImportTemplatePagedQueryResponse, GetImportTemplatePagedAPIResponse>();
    }
}
