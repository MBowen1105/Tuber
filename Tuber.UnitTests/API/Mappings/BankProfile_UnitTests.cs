using AutoMapper;
using Tuber.API.Mappings;

namespace Tuber.UnitTests.API.Mappings;
internal class BankProfile_UnitTests
{
    [Test]
    public void BankProfile_IsValid()
    {
        var config = new MapperConfiguration(cfg => cfg.AddProfile<BankProfile>());

        config.AssertConfigurationIsValid();
    }
}
