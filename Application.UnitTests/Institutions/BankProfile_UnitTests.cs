using AutoMapper;
using Tuber.Application.Institutions;

namespace Tuber.Application.UnitTests.Institutions;
internal class InstitutionProfile_UnitTests
{
    [Test, Parallelizable]
    public void InstitutionProfile_IsValid()
    {
        var config = new MapperConfiguration(cfg => cfg.AddProfile<InstitutionProfile>());

        config.AssertConfigurationIsValid();
    }
}
