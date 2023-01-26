using AutoMapper;
using Tuber.Application.InstitutionAccounts;

namespace Tuber.Application.UnitTests.InstitutionAccounts;
internal class InstitutionAccountProfile_UnitTests
{
    [Test]
    public void InstitutionAccountProfile_IsValid()
    {
        var config = new MapperConfiguration(cfg => cfg.AddProfile<InstitutionAccountProfile>());

        config.AssertConfigurationIsValid();
    }
}
