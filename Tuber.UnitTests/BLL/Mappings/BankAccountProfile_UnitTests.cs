using AutoMapper;
using Tuber.BLL.Mappings;
namespace Tuber.UnitTests.BLL.Mappings;
internal class BankAccountProfile_UnitTests
{
    [Test]
    public void BankAccountProfile_IsValid()
    {
        var config = new MapperConfiguration(cfg => cfg.AddProfile<BankAccountProfile>());

        config.AssertConfigurationIsValid();
    }
}
