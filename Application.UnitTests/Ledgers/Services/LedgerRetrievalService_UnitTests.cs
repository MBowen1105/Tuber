using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Ledgers.Services;
using Tuber.Domain.Models;

namespace Application.UnitTests.Ledgers.Services;
public class LedgerRetrievalService_UnitTests
{
    private readonly Guid CategorySubcategoryId = Guid.Parse("975f7dda-5b90-4002-b511-9e378371e643");
    private readonly Guid MatchGuid = Guid.Parse("d4bb9734-fd5d-47e5-a0c1-818d343cf05e");
    private readonly Mock<ILedgerRepository> _mockLedgerRepo = new();

    [SetUp]
    public void SetUp()
    {

    }

    [Test]
    public void Test()
    {
        //_mockLedgerRepo.Setup(x => x.QueryDatabase(
        //    It.IsAny<FormattableString>()))
        //    .Returns(new Ledger
        //    {
        //        LedgerId = MatchGuid,
        //        Description = "Test Description",
        //        CategorySubcategoryId = CategorySubcategoryId,
        //    });

        //var sut = new LedgerRetrievalService(_mockLedgerRepo.Object);

        //var serviceResult = sut.SuggestCategorisation(
        //    bankAccountId: Guid.NewGuid(),
        //    dateISO8601: "20220101",
        //    description: "test desc",
        //    reference: "",
        //    moneyIn: 100.0,
        //    moneyOut: null);

        //serviceResult.IsSuccess.Should().BeTrue();
        //serviceResult.HasFailed.Should().BeFalse();
        //serviceResult.Exceptions.Count.Should().Be(0);

        //serviceResult.Payload.Should().Be(MatchGuid);

    }
}
