using AutoMapper;
using Tuber.Application.ImportTemplates;

namespace Tuber.UnitTests.BLL.ImportTemplates;
internal class ImportTemplateProfile_UnitTests
{
    [Test, Parallelizable]
    public void ImportTemplateProfile_IsValid()
    {
        var config = new MapperConfiguration(cfg => cfg.AddProfile<ImportTemplateProfile>());

        config.AssertConfigurationIsValid();
    }
}
