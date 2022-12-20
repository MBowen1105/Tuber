using AutoMapper;
using Tuber.Application.Banks;

namespace Tuber.Application.UnitTests.Banks;
internal class BankProfile_UnitTests
{
    [Test, Parallelizable]
    public void BankProfile_IsValid()
    {
        var config = new MapperConfiguration(cfg => cfg.AddProfile<BankProfile>());

        config.AssertConfigurationIsValid();
    }
}
