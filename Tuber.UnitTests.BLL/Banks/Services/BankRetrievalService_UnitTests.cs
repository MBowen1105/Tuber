using FluentAssertions;
using Moq;
using Tuber.BLL.Banks.Services;
using Tuber.Domain.Exceptions;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Models;

namespace Tuber.UnitTests.BLL.Banks.Services;
internal class BankRetrievalService_UnitTests
{
    private static readonly Guid GOOD_ID = Guid.Parse("2a6976f3-8006-4635-b6e8-8c5b0cfac6fe");
    private static readonly Guid BAD_ID = Guid.Parse("1ff93507-902d-4eb1-a264-3ec211334db5");

    private readonly Mock<IBankRepository> _mockBankRepository = new();

    private readonly Bank GOOD_Bank = new()
    {
        BankId = GOOD_ID,
    };
    private IBankRetrievalService _sut;

    [SetUp]
    public void Setup()
    {
        _mockBankRepository.Setup(x => x.GetById(It.Is<Guid>(x => x == GOOD_ID)))
            .Returns(GOOD_Bank);

        _mockBankRepository.Setup(x => x.GetById(It.Is<Guid>(x => x == BAD_ID)))
            .Returns(new Bank());

        _mockBankRepository.Setup(x => x.GetPaged(
            It.Is<int>(x => x == 1),
            It.Is<int>(x => x == 2)))
                .Returns(new List<Bank>() { GOOD_Bank, GOOD_Bank });

        _mockBankRepository.Setup(x => x.GetPaged(
            It.Is<int>(x => x == 2),
            It.Is<int>(x => x == 2)))
                .Returns(new List<Bank>());

        _sut = new BankRetrievalService(_mockBankRepository.Object);
    }

    #region "GetById"
    [Test, Parallelizable]
    public void GetById_ExistingBank_ReturnsBankWithNoExceptions()
    {
        var serviceResult = _sut.GetById(GOOD_ID);

        serviceResult.IsSuccess.Should().BeTrue();
        serviceResult.Exceptions.Count.Should().Be(0);
        serviceResult.Payload.Should().BeEquivalentTo(GOOD_Bank);
    }

    [Test, Parallelizable]
    public void GetById_NonExistingBank_ReturnsNullBankWithExceptions()
    {
        var serviceResult = _sut.GetById(BAD_ID);

        serviceResult.IsSuccess.Should().BeFalse();
        serviceResult.Exceptions.Count.Should().Be(1);
        serviceResult.Exceptions.First().Should().BeOfType<EntityDoesNotExistException>();
        serviceResult.Payload.Should().BeEquivalentTo(new Bank());
    }
    #endregion

    #region "GetPaged"

    [Test, Parallelizable]
    public void GetPaged_ExistingBanks_ReturnsBankListWithNoExceptions()
    {
        var serviceResult = _sut.GetPaged(1,2);

        serviceResult.IsSuccess.Should().BeTrue();
        serviceResult.Exceptions.Count.Should().Be(0);

        serviceResult.Payload.Count().Should().Be(2);
    }

    [Test, Parallelizable]
    public void GetPaged_WithNoBanks_ReturnsEmptyBankListWithNoExceptions()
    {
        var serviceResult = _sut.GetPaged(2, 2);

        serviceResult.IsSuccess.Should().BeTrue();
        serviceResult.Exceptions.Count.Should().Be(0);

        serviceResult.Payload.Count().Should().Be(0);
    }
    #endregion

}
