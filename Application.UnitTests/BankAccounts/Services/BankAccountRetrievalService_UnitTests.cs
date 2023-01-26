using FluentAssertions;
using Moq;
using Tuber.Application.InstitutionAccounts.Services;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Exceptions;
using Tuber.Domain.Models;

namespace Tuber.Application.UnitTests.InstitutionAccounts.Services;
internal class InstitutionAccountRetrievalService_UnitTests
{
    private static readonly Guid GOOD_ID = Guid.Parse("2a6976f3-8006-4635-b6e8-8c5b0cfac6fe");
    private static readonly Guid BAD_ID = Guid.Parse("1ff93507-902d-4eb1-a264-3ec211334db5");

    private readonly Mock<IInstitutionAccountRepository> _mockInstitutionAccountRepository = new();

    private readonly InstitutionAccount GOOD_BANKACCOUNT = new()
    {
        InstitutionAccountId = GOOD_ID,
    };
    private IInstitutionAccountRetrievalService _sut;

    [SetUp]
    public void Setup()
    {
        _mockInstitutionAccountRepository.Setup(x => x.GetById(It.Is<Guid>(x => x == GOOD_ID)))
            .Returns(GOOD_BANKACCOUNT);

        _mockInstitutionAccountRepository.Setup(x => x.GetById(It.Is<Guid>(x => x == BAD_ID)))
            .Returns(new InstitutionAccount());

        _mockInstitutionAccountRepository.Setup(x => x.GetPaged(
            It.Is<int>(x => x == 1),
            It.Is<int>(x => x == 2)))
                .Returns(new List<InstitutionAccount>() { GOOD_BANKACCOUNT, GOOD_BANKACCOUNT });

        _mockInstitutionAccountRepository.Setup(x => x.GetPaged(
            It.Is<int>(x => x == 2),
            It.Is<int>(x => x == 2)))
                .Returns(new List<InstitutionAccount>());

        _sut = new InstitutionAccountRetrievalService(_mockInstitutionAccountRepository.Object);
    }

    #region "GetById"
    [Test, Parallelizable]
    public void GetById_ExistingInstitutionAccount_ReturnsInstitutionAccountWithNoExceptions()
    {
        var serviceResult = _sut.GetById(GOOD_ID);

        serviceResult.IsSuccess.Should().BeTrue();
        serviceResult.Exceptions.Count.Should().Be(0);
        serviceResult.Payload.Should().BeEquivalentTo(GOOD_BANKACCOUNT);
    }

    [Test, Parallelizable]
    public void GetById_NonExistingInstitutionAccount_ReturnsNullInstitutionAccountWithExceptions()
    {
        var serviceResult = _sut.GetById(BAD_ID);

        serviceResult.IsSuccess.Should().BeFalse();
        serviceResult.Exceptions.Count.Should().Be(1);
        serviceResult.Exceptions.First().Should().BeOfType<EntityDoesNotExistException>();
        serviceResult.Payload.Should().BeEquivalentTo(new InstitutionAccount());
    }
    #endregion

    #region "GetPaged"

    [Test, Parallelizable]
    public void GetPaged_ExistingInstitutionAccounts_ReturnsInstitutionAccountListWithNoExceptions()
    {
        var serviceResult = _sut.GetPaged(1,2);

        serviceResult.IsSuccess.Should().BeTrue();
        serviceResult.Exceptions.Count.Should().Be(0);

        serviceResult.Payload.Count().Should().Be(2);
    }

    [Test, Parallelizable]
    public void GetPaged_WithNoInstitutionAccounts_ReturnsEmptyInstitutionAccountListWithNoExceptions()
    {
        var serviceResult = _sut.GetPaged(2, 2);

        serviceResult.IsSuccess.Should().BeTrue();
        serviceResult.Exceptions.Count.Should().Be(0);

        serviceResult.Payload.Count().Should().Be(0);
    }
    #endregion

}
