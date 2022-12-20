using FluentAssertions;
using Moq;
using Tuber.BLL.BankAccounts.Services;
using Tuber.Domain.Exceptions;
using Tuber.BLL.Interfaces;
using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Models;

namespace Tuber.UnitTests.BLL.BankAccounts.Services;
internal class BankAccountRetrievalService_UnitTests
{
    private static readonly Guid GOOD_ID = Guid.Parse("2a6976f3-8006-4635-b6e8-8c5b0cfac6fe");
    private static readonly Guid BAD_ID = Guid.Parse("1ff93507-902d-4eb1-a264-3ec211334db5");

    private readonly Mock<IBankAccountRepository> _mockBankAccountRepository = new();

    private readonly BankAccount GOOD_BANKACCOUNT = new()
    {
        BankAccountId = GOOD_ID,
    };

    private IBankAccountRetrievalService _sut;

    [SetUp]
    public void Setup()
    {
        _mockBankAccountRepository.Setup(x => x.GetById(It.Is<Guid>(x => x == GOOD_ID)))
            .Returns(GOOD_BANKACCOUNT);

        _mockBankAccountRepository.Setup(x => x.GetById(It.Is<Guid>(x => x == BAD_ID)))
            .Returns(new BankAccount());

        _mockBankAccountRepository.Setup(x => x.GetPaged(
            It.Is<int>(x => x == 1),
            It.Is<int>(x => x == 4)))
                .Returns(new List<BankAccount>()
                {
                    GOOD_BANKACCOUNT,
                    GOOD_BANKACCOUNT,
                    GOOD_BANKACCOUNT,
                    GOOD_BANKACCOUNT
                });

        _mockBankAccountRepository.Setup(x => x.GetPaged(
            It.Is<int>(x => x == 2),
            It.Is<int>(x => x == 3)))
                .Returns(new List<BankAccount>()
                {
                    GOOD_BANKACCOUNT
                });

        _mockBankAccountRepository.Setup(x => x.GetPaged(
            It.Is<int>(x => x == 2),
            It.Is<int>(x => x == 4)))
                .Returns(new List<BankAccount>());

        _sut = new BankAccountRetrievalService(_mockBankAccountRepository.Object);
    }

    #region "GetById"
    [Test, Parallelizable]
    public void GetById_ExistingBankAccount_ReturnsBankAccountWithNoExceptions()
    {
        var serviceResult = _sut.GetById(GOOD_ID);

        serviceResult.IsSuccess.Should().BeTrue();
        serviceResult.HasFailed.Should().BeFalse();
        serviceResult.Exceptions.Count.Should().Be(0);
        serviceResult.Payload.Should().BeEquivalentTo(GOOD_BANKACCOUNT);
    }

    [Test, Parallelizable]
    public void GetById_NonExistingBankAccount_ReturnsNullBankAccountWithExceptions()
    {
        var serviceResult = _sut.GetById(BAD_ID);

        serviceResult.IsSuccess.Should().BeFalse();
        serviceResult.HasFailed.Should().BeTrue();
        serviceResult.Exceptions.Count.Should().Be(1);
        serviceResult.Exceptions.First().Should().BeOfType<EntityDoesNotExistException>();
        serviceResult.Payload.Should().BeEquivalentTo(new BankAccount());
    }
    #endregion

    #region "GetPaged"

    [Test, Parallelizable]
    public void GetPaged_ExistingBankAccounts_ReturnsBankAccountListPage1WithNoExceptions()
    {
        var serviceResult = _sut.GetPaged(1, 4);

        serviceResult.IsSuccess.Should().BeTrue();
        serviceResult.HasFailed.Should().BeFalse();
        serviceResult.Exceptions.Count.Should().Be(0);

        serviceResult.Payload.Count().Should().Be(4);
    }

    [Test, Parallelizable]
    public void GetPaged_ExistingBankAccounts_ReturnsBankAccountPagedListPage2WithNoExceptions()
    {
        var serviceResult = _sut.GetPaged(2, 3);

        serviceResult.IsSuccess.Should().BeTrue();
        serviceResult.HasFailed.Should().BeFalse();
        serviceResult.Exceptions.Count.Should().Be(0);

        serviceResult.Payload.Count().Should().Be(1);
    }

    [Test, Parallelizable]
    public void GetPaged_WithNoBankAccounts_ReturnsEmptyBankAccountListWithNoExceptions()
    {
        var serviceResult = _sut.GetPaged(2, 4);

        serviceResult.IsSuccess.Should().BeTrue();
        serviceResult.HasFailed.Should().BeFalse();
        serviceResult.Exceptions.Count.Should().Be(0);

        serviceResult.Payload.Count().Should().Be(0);
    }
    #endregion

}
