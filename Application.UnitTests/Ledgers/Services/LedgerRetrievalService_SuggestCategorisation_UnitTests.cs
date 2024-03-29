﻿using FluentAssertions;
using Moq;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Common.Interfaces.Clock;
using Tuber.Application.Ledgers.Services;
using Tuber.Domain.Models;

namespace Application.UnitTests.Ledgers.Services;
public class LedgerRetrievalService_SuggestCategorisation_UnitTests
{
    private readonly Mock<ILedgerRepository> _mockLedgerRepo = new();
    private readonly Mock<IAppConfigRepository> _mockAppConfigRepo = new();
    private readonly Mock<IClock> _mockSystemClock = new();
    private readonly DateTime TodayUtc = new(2023, 1, 6);

    private readonly Guid InstitutionAccountId = Guid.NewGuid();
    
    private readonly Guid LedgerId1 = Guid.NewGuid();
    private readonly Guid LedgerId2 = Guid.NewGuid();
    private readonly Guid LedgerId3 = Guid.NewGuid();

    private readonly Guid CategoryId1 = Guid.NewGuid();
    private readonly Guid CategoryId2 = Guid.NewGuid();
    private readonly Guid CategoryId3 = Guid.NewGuid();

    private readonly Guid SubcategoryId1 = Guid.NewGuid();
    private readonly Guid SubcategoryId2 = Guid.NewGuid();
    private readonly Guid SubcategoryId3 = Guid.NewGuid();

    private ILedgerRetrievalService _sut;

    [SetUp]
    public void SetUp()
    {
        _mockSystemClock.Setup(x => x.TodayUtc())
            .Returns(TodayUtc);

        _mockLedgerRepo.Setup(x => x.GetBetweenDates(
            It.IsAny<Guid>(),
            It.IsAny<DateTime>(),
            It.IsAny<DateTime>()))
                .Returns(new List<Ledger>()
            {
                new Ledger
                {
                    LedgerId = LedgerId1,
                    InstitutionAccountId = InstitutionAccountId,
                    DateUtc = TodayUtc,
                    Description = "M&S BANK",
                    Reference = "",
                    MoneyIn = 100.0,
                    MoneyOut = null,
                    CategoryId = CategoryId1,
                    SubcategoryId = SubcategoryId1,
                    IsReconciled = true,
                },
                new Ledger
                {
                    LedgerId = LedgerId2,
                    InstitutionAccountId = InstitutionAccountId,
                    DateUtc= TodayUtc.AddDays(-1),
                    Description = "M&S BANK",
                    Reference = "",
                    MoneyIn = null,
                    MoneyOut = 100.0,
                    CategoryId = CategoryId2,
                    SubcategoryId = SubcategoryId2,
                    IsReconciled = true,
                },
                new Ledger
                {
                    LedgerId = LedgerId3,
                    InstitutionAccountId = InstitutionAccountId,
                    DateUtc = TodayUtc.AddDays(-2),
                    Description = "M&S BANK",
                    Reference = "Ref1",
                    MoneyIn = 100.0,
                    MoneyOut = null,
                    CategoryId = CategoryId3,
                    SubcategoryId = SubcategoryId3,
                    IsReconciled = true,
                }
            });

        _mockAppConfigRepo.Setup(x => x.Get())
                .Returns(new AppConfig());

        _sut = new LedgerRetrievalService(
            _mockLedgerRepo.Object,
            _mockAppConfigRepo.Object,
            _mockSystemClock.Object);
    }

    [Test, Parallelizable]
    public void SuggestCategorisation_ExactMatch_ReturnsLedgerEntry1()
    {
        var serviceResult = _sut.SuggestCategorisation(
            bankAccountId: InstitutionAccountId,
            description: "M&S BANK",
            reference: "",
            moneyIn: 100.0,
            moneyOut: null);

        serviceResult.IsSuccess.Should().BeTrue();
        serviceResult.HasFailed.Should().BeFalse();
        serviceResult.Exceptions.Count.Should().Be(0);

        serviceResult.Payload.LedgerId.Should().Be(LedgerId1);

    }

    [Test, Parallelizable]
    public void SuggestCategorisation_MatchWithoutAmounts_ReturnsLedgerEntry1()
    {
        var serviceResult = _sut.SuggestCategorisation(
            bankAccountId: InstitutionAccountId,
            description: "M&S BANK",
            reference: "",
            moneyIn: 9.0,
            moneyOut: null);

        serviceResult.IsSuccess.Should().BeTrue();
        serviceResult.HasFailed.Should().BeFalse();
        serviceResult.Exceptions.Count.Should().Be(0);

        serviceResult.Payload.LedgerId.Should().Be(LedgerId1);

    }

    [Test, Parallelizable]
    public void SuggestCategorisation_MatchJustDescriptionAndReference_ReturnsLedgerEntry3()
    {
        var serviceResult = _sut.SuggestCategorisation(
            bankAccountId: InstitutionAccountId,
            description: "M&S BANK",
            reference: "Ref1",
            moneyIn: 100.0,
            moneyOut: null);

        serviceResult.IsSuccess.Should().BeTrue();
        serviceResult.HasFailed.Should().BeFalse();
        serviceResult.Exceptions.Count.Should().Be(0);

        serviceResult.Payload.LedgerId.Should().Be(LedgerId3);

    }

    [Test, Parallelizable]
    public void SuggestCategorisation_MatchJustDescription_ReturnsLedgerEntry1()
    {
        var serviceResult = _sut.SuggestCategorisation(
            bankAccountId: InstitutionAccountId,
            description: "M&S BANK",
            reference: "No ref match",
            moneyIn: 9.99,
            moneyOut: null);

        serviceResult.IsSuccess.Should().BeTrue();
        serviceResult.HasFailed.Should().BeFalse();
        serviceResult.Exceptions.Count.Should().Be(0);

        serviceResult.Payload.LedgerId.Should().Be(LedgerId1);

    }
}
