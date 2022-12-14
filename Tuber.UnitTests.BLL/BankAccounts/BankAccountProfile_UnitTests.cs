using AutoMapper;
using Tuber.BLL.BankAccounts;

namespace Tuber.UnitTests.BLL.BankAccounts;
internal class BankAccountProfile_UnitTests
{
    [Test]
    public void BankAccountProfile_IsValid()
    {
        var config = new MapperConfiguration(cfg => cfg.AddProfile<BankAccountProfile>());

        config.AssertConfigurationIsValid();
    }
}
