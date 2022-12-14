using FluentAssertions;
using Moq;
using Tuber.BLL.Banks.Services;
using Tuber.Domain.Exceptions;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Interfaces.DAL;
using Tuber.Domain.Models;

namespace Tuber.UnitTests.BLL.Banks.Services;
internal class BankUpdaterService_UnitTests
{
    private static readonly Guid GOOD_ID = Guid.Parse("2a6976f3-8006-4635-b6e8-8c5b0cfac6fe");
    private static readonly Guid BAD_ID = Guid.Parse("1ff93507-902d-4eb1-a264-3ec211334db5");
    private static readonly DateTime DATETIMESTAMP = new(2022, 1, 12);

    private readonly Mock<IBankRepository> _mockBankRepository = new();

    private readonly Bank NEW_BANK = new()
    {
        BankId = GOOD_ID,
        Name = "New Bank",
        OrderBy = 10,
        //IsDeleted = false,
        //BankAccounts = new List<BankAccount>(),
        //CreatedByUserId = Guid.NewGuid(),
        //CreatedOnUtc = DATETIMESTAMP,
        //UpdatedByUserId = null,
        //UpdatedOnUtc = null,
    };

    private IBankUpdaterService _sut;

    [SetUp]
    public void Setup()
    {
        _mockBankRepository.Setup(x => x.Add(It.Is<Bank>(x => x.Name == NEW_BANK.Name)))
            .Returns(NEW_BANK);

        _mockBankRepository.Setup(x => x.Add(It.Is<Bank>(x => x.Name != NEW_BANK.Name)))
            .Returns(new Bank());

        _sut = new BankUpdaterService(_mockBankRepository.Object);
    }

    #region "BankAdd"
    [Test, Parallelizable]
    public void Add_NewBank_ReturnsNewBankWithNoExceptions()
    {
        var serviceResult = _sut.Add(NEW_BANK.Name, NEW_BANK.OrderBy);

        serviceResult.IsSuccess.Should().BeTrue();
        serviceResult.Exceptions.Count.Should().Be(0);
        serviceResult.Payload.Should().BeEquivalentTo(NEW_BANK);
    }

    [Test, Parallelizable]
    public void GetById_NonExistingBank_ReturnsNullBankWithExceptions()
    {
        var serviceResult = _sut.Add("Already Existing Bank", 10);

        serviceResult.IsSuccess.Should().BeFalse();
        serviceResult.Exceptions.Count.Should().Be(1);
        serviceResult.Exceptions.First().Should().BeOfType<EntityAlreadyExistsException>();
        serviceResult.Payload.Should().BeEquivalentTo(new Bank());
    }
    #endregion

    #region "BankUpdate"

    #endregion


    #region "BankDelete"

    #endregion
}
