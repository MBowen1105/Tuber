using AutoMapper;
using Tuber.BLL.ImportTemplates.Queries.GetImportTemplateById;

namespace Tuber.BLL.ImportTemplates;
public class ImportTemplateProfile : Profile
{
    public ImportTemplateProfile()
    {
        CreateMap<GetImportTemplateByIdQueryResponse, GetImportTemplateByIdAPIResponse>();       
    }
}
