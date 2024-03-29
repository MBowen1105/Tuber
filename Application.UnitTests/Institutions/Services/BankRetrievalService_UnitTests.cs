﻿using FluentAssertions;
using Moq;
using Tuber.Application.Institutions.Services;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Exceptions;
using Tuber.Domain.Models;

namespace Tuber.Application.UnitTests.Banks.Services;
internal class BankRetrievalService_UnitTests
{
    private static readonly Guid GOOD_ID = Guid.Parse("2a6976f3-8006-4635-b6e8-8c5b0cfac6fe");
    private static readonly Guid BAD_ID = Guid.Parse("1ff93507-902d-4eb1-a264-3ec211334db5");

    private readonly Mock<IInstitutionRepository> _mockBankRepository = new();

    private readonly Institution GOOD_Bank = new()
    {
        InstitutionId = GOOD_ID,
    };
    private IInstitutionRetrievalService _sut;

    [SetUp]
    public void Setup()
    {
        _mockBankRepository.Setup(x => x.GetById(It.Is<Guid>(x => x == GOOD_ID)))
            .Returns(GOOD_Bank);

        _mockBankRepository.Setup(x => x.GetById(It.Is<Guid>(x => x == BAD_ID)))
            .Returns(new Institution());

        _mockBankRepository.Setup(x => x.GetPaged(
            It.Is<int>(x => x == 1),
            It.Is<int>(x => x == 2)))
                .Returns(new List<Institution>() { GOOD_Bank, GOOD_Bank });

        _mockBankRepository.Setup(x => x.GetPaged(
            It.Is<int>(x => x == 2),
            It.Is<int>(x => x == 2)))
                .Returns(new List<Institution>());

        _sut = new InstitutionRetrievalService(_mockBankRepository.Object);
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
        serviceResult.Payload.Should().BeEquivalentTo(new Institution());
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
