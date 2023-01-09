using FluentAssertions;
using Moq;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Interfaces.SystemClock;
using Tuber.Application.Ledgers.Services;
using Tuber.Domain.Models;

namespace Application.UnitTests.Ledgers.Services;
public class LedgerRetrievalService_SuggestCategorisation_UnitTests
{
    private readonly Mock<ILedgerRepository> _mockLedgerRepo = new();
    private readonly Mock<ISystemClock> _mockSystemClock = new();
    private readonly DateTime TodayUtc = new(2023, 1, 6);

    private readonly Guid BankAccountId = Guid.NewGuid();
    
    private readonly Guid LedgerId1 = Guid.NewGuid();
    private readonly Guid LedgerId2 = Guid.NewGuid();
    private readonly Guid LedgerId3 = Guid.NewGuid();

    private readonly Guid CategorySubcategoryId1 = Guid.NewGuid();
    private readonly Guid CategorySubcategoryId2 = Guid.NewGuid();
    private readonly Guid CategorySubcategoryId3 = Guid.NewGuid();
    
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
                    BankAccountId = BankAccountId,
                    DateUtc = TodayUtc,
                    Description = "M&S BANK",
                    Reference = "",
                    MoneyIn = 100.0,
                    MoneyOut = null,
                    CategorySubcategoryId = CategorySubcategoryId1,
                },
                new Ledger
                {
                    LedgerId = LedgerId2,
                    BankAccountId = BankAccountId,
                    DateUtc= TodayUtc.AddDays(-1),
                    Description = "M&S BANK",
                    Reference = "",
                    MoneyIn = null,
                    MoneyOut = 100.0,
                    CategorySubcategoryId = CategorySubcategoryId2,
                },
                new Ledger
                {
                    LedgerId = LedgerId3,
                    BankAccountId = BankAccountId,
                    DateUtc = TodayUtc.AddDays(-2),
                    Description = "M&S BANK",
                    Reference = "Ref1",
                    MoneyIn = 100.0,
                    MoneyOut = null,
                    CategorySubcategoryId = CategorySubcategoryId3,
                }
            });

        _sut = new LedgerRetrievalService(
            _mockLedgerRepo.Object,
            _mockSystemClock.Object);
    }

    [Test, Parallelizable]
    public void SuggestCategorisation_ExactMatch_ReturnsLedgerEntry1()
    {
        var serviceResult = _sut.SuggestCategorisation(
            bankAccountId: BankAccountId,
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
            bankAccountId: BankAccountId,
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
            bankAccountId: BankAccountId,
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
            bankAccountId: BankAccountId,
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
