using FluentAssertions;
using Moq;
using Tuber.BLL.BankAccountAccounts.Services;
using Tuber.BLL.Interfaces;
using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Models;

namespace Tuber.UnitTests.BLL.BankAccounts.Services;
internal class BankAccountUpdaterService_UnitTests
{
    private readonly Mock<IBankAccountRepository> _mockBankAccountRepository = new();

    private readonly Guid GoodBankAccountId = Guid.Parse("2a6976f3-8006-4635-b6e8-8c5b0cfac6fe");

    private readonly BankAccount GoodBankAccount = new()
    {
        BankAccountId = Guid.Empty,
        BankAccountName = "Bank Account Name",
        UKBankAccount = "12345678",
        UKSortCode = "010101",
        OrderBy = 10,
        BankId = Guid.NewGuid(),
        ImportTemplateId = null,
    };

    private IBankAccountUpdaterService _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new BankAccountUpdaterService(_mockBankAccountRepository.Object);

        //  Adding a Good Bank Account returns a Bank Account with Good ID
        _mockBankAccountRepository.Setup(x => x.Add(It.IsAny<BankAccount>()))
             .Returns(new BankAccount { BankAccountId = GoodBankAccountId });
    }

    #region "Add"
    [Test, Parallelizable]
    public void Add_BankAccount_ReturnsBankAccountWithIdAndNoExceptions()
    {

        var serviceResult = _sut.Add(
            GoodBankAccount.BankAccountName,
            GoodBankAccount.UKBankAccount,
            GoodBankAccount.UKSortCode,
            GoodBankAccount.OrderBy,
            GoodBankAccount.BankId,
            GoodBankAccount.ImportTemplateId);

        serviceResult.IsSuccess.Should().BeTrue();
        serviceResult.HasFailed.Should().BeFalse();
        serviceResult.Exceptions.Count.Should().Be(0);

        serviceResult.Payload.BankAccountId.Should().Be(GoodBankAccountId);
    }
    #endregion

    #region "Update"
    [Test, Parallelizable]
    public void Update_ExistingBankAccount_ReturnsUpdatedAccountWithNoExceptions()
    {
        _mockBankAccountRepository.Setup(x => x.Update(It.IsAny<BankAccount>()))
             .Returns(new BankAccount { BankAccountId = GoodBankAccountId });

        var serviceResult = _sut.Update(
            GoodBankAccount.BankAccountId,
            GoodBankAccount.BankAccountName,
            GoodBankAccount.UKBankAccount,
            GoodBankAccount.UKSortCode,
            GoodBankAccount.OrderBy,
            GoodBankAccount.BankId,
            GoodBankAccount.ImportTemplateId);

        serviceResult.IsSuccess.Should().BeTrue();
        serviceResult.HasFailed.Should().BeFalse();
        serviceResult.Exceptions.Count.Should().Be(0);

        serviceResult.Payload.Should().BeEquivalentTo(new BankAccount { BankAccountId = GoodBankAccountId });
    }

    [Test, Parallelizable]
    public void Update_MissingBankAccount_ReturnsExceptionWithNullPayload()
    {
        _mockBankAccountRepository.Setup(x => x.Update(It.IsAny<BankAccount>()))
             .Returns(new BankAccount { BankAccountId = GoodBankAccountId });

        var serviceResult = _sut.Update(
            GoodBankAccount.BankAccountId,
            GoodBankAccount.BankAccountName,
            GoodBankAccount.UKBankAccount,
            GoodBankAccount.UKSortCode,
            GoodBankAccount.OrderBy,
            GoodBankAccount.BankId,
            GoodBankAccount.ImportTemplateId);

        serviceResult.IsSuccess.Should().BeTrue();
        serviceResult.HasFailed.Should().BeFalse();
        serviceResult.Exceptions.Count.Should().Be(0);

        serviceResult.Payload.Should().BeEquivalentTo(new BankAccount { BankAccountId = GoodBankAccountId });
    }
    #endregion
}
