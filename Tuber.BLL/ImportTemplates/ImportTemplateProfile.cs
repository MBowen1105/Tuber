using AutoMapper;
using Tuber.BLL.ImportTemplates.Queries.GetImportTemplateById;
using Tuber.Domain.Models;

namespace Tuber.BLL.ImportTemplates;
public class ImportTemplateProfile : Profile
{
    public ImportTemplateProfile()
    {
        CreateMap<ImportTemplate, GetImportTemplateByIdQueryResponse>()
            .ForMember(dest => dest.Exceptions, act => act.Ignore());

        CreateMap<GetImportTemplateByIdQueryResponse, GetImportTemplateByIdAPIResponse>();
    }
}
