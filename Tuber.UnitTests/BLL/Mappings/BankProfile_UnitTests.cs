using AutoMapper;
using Tuber.BLL.Mappings;

namespace Tuber.UnitTests.BLL.Mappings;
internal class BankProfile_UnitTests
{
    [Test]
    public void BankProfile_IsValid()
    {
        var config = new MapperConfiguration(cfg => cfg.AddProfile<BankProfile>());

        config.AssertConfigurationIsValid();
    }
}
