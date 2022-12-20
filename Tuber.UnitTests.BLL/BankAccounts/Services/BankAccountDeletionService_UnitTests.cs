using FluentAssertions;
using Moq;
using Tuber.BLL.BankAccounts.Services;
using Tuber.Domain.Exceptions;
using Tuber.BLL.Interfaces;
using Tuber.Domain.Interfaces.DAL;

namespace Tuber.UnitTests.BLL.BankAccounts.Services;
internal class BankAccountDeletionService_UnitTests
{
    private readonly Mock<IBankAccountRepository> _mockBankAccountRepository = new();

    private IBankAccountDeletionService _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new BankAccountDeletionService(_mockBankAccountRepository.Object);
    }

    #region "Delete"
    [Test, Parallelizable]
    public void Delete_ExistingBankAccount_ReturnsOneWithNoExceptions()
    {
        var GoodID = Guid.NewGuid();
        _mockBankAccountRepository.Setup(x => x.Delete(It.Is<Guid>(x => x.Equals(GoodID))))
             .Returns(1);

        var serviceResult = _sut.Delete(GoodID);

        serviceResult.IsSuccess.Should().BeTrue();
        serviceResult.HasFailed.Should().BeFalse();
        serviceResult.Exceptions.Count.Should().Be(0);

        serviceResult.Payload.Should().Be(1);
    }

    [Test, Parallelizable]
    public void Delete_MissingBankAccount_ReturnsZeroWithNoExceptions()
    {
        var BadID = Guid.NewGuid();
        _mockBankAccountRepository.Setup(x => x.Delete(It.Is<Guid>(x => x.Equals(BadID))))
             .Returns(0);

        var serviceResult = _sut.Delete(BadID);

        serviceResult.IsSuccess.Should().BeFalse();
        serviceResult.HasFailed.Should().BeTrue();
        serviceResult.Exceptions.Count.Should().Be(1);
        serviceResult.Exceptions.First().Should().BeOfType<EntityDoesNotExistException>();

        serviceResult.Payload.Should().Be(0);
    }
    #endregion

}
