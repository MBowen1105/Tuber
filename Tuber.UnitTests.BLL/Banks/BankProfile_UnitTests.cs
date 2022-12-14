using AutoMapper;
using Tuber.BLL.Banks;

namespace Tuber.UnitTests.BLL.Banks;
internal class BankProfile_UnitTests
{
    [Test, Parallelizable]
    public void BankProfile_IsValid()
    {
        var config = new MapperConfiguration(cfg => cfg.AddProfile<BankProfile>());

        config.AssertConfigurationIsValid();
    }
}
