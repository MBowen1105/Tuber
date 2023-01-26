using FluentAssertions;
using Moq;
using Tuber.Application.Institutions.Services;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Exceptions;
using Tuber.Domain.Models;

namespace Tuber.Application.UnitTests.Banks.Services;
internal class BankUpdaterService_UnitTests
{
    private static readonly Guid GOOD_ID = Guid.Parse("2a6976f3-8006-4635-b6e8-8c5b0cfac6fe");
    private static readonly Guid BAD_ID = Guid.Parse("1ff93507-902d-4eb1-a264-3ec211334db5");
    private static readonly DateTime DATETIMESTAMP = new(2022, 1, 12);

    private readonly Mock<IInstitutionRepository> _mockBankRepository = new();

    private readonly Institution NEW_BANK = new()
    {
        InstitutionId = GOOD_ID,
        InstitutionName = "New Bank",
        OrderBy = 10,
    };

    private IInstitutionUpdaterService _sut;

    [SetUp]
    public void Setup()
    {
        _mockBankRepository.Setup(x => x.Add(It.Is<Institution>(x => x.InstitutionName == NEW_BANK.InstitutionName)))
            .Returns(NEW_BANK);

        _mockBankRepository.Setup(x => x.Add(It.Is<Institution>(x => x.InstitutionName != NEW_BANK.InstitutionName)))
            .Returns(new Institution());

        _sut = new InstitutionUpdaterService(_mockBankRepository.Object);
    }

    #region "BankAdd"
    [Test, Parallelizable]
    public void Add_NewBank_ReturnsNewBankWithNoExceptions()
    {
        var serviceResult = _sut.Add(NEW_BANK.InstitutionName, NEW_BANK.OrderBy);

        serviceResult.IsSuccess.Should().BeTrue();
        serviceResult.Exceptions.Count.Should().Be(0);
        serviceResult.Payload.Should().BeEquivalentTo(NEW_BANK);
    }

    [Test, Parallelizable]
    public void Add_ExistingBank_ReturnsNullBankWithExceptions()
    {
        var serviceResult = _sut.Add("Already Existing Bank", 10);

        serviceResult.IsSuccess.Should().BeFalse();
        serviceResult.Exceptions.Count.Should().Be(1);
        serviceResult.Exceptions.First().Should().BeOfType<EntityAlreadyExistsException>();
        serviceResult.Payload.Should().BeEquivalentTo(new Institution());
    }
    #endregion


    #region "BankUpdate"

    #endregion


    #region "BankDelete"

    #endregion
}
