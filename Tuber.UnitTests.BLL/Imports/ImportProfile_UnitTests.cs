using AutoMapper;
using Tuber.Application.Imports;

namespace Tuber.UnitTests.BLL.Imports;
internal class ImportProfile_UnitTests
{
    [Test, Parallelizable]
    public void ImportProfile_IsValid()
    {
        var config = new MapperConfiguration(cfg => cfg.AddProfile<ImportProfile>());

        config.AssertConfigurationIsValid();
    }
}
