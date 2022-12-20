using AutoMapper;
using Tuber.Application.BankAccounts;

namespace Tuber.Application.UnitTests.BankAccounts;
internal class BankAccountProfile_UnitTests
{
    [Test]
    public void BankAccountProfile_IsValid()
    {
        var config = new MapperConfiguration(cfg => cfg.AddProfile<BankAccountProfile>());

        config.AssertConfigurationIsValid();
    }
}
