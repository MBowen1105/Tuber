using FluentAssertions;
using Moq;
using Tuber.Application.Banks.Services;
using Tuber.Application.Categories.Services;
using Tuber.Application.Common.Interfaces;
using Tuber.Application.Common.Interfaces.Persistence;
using Tuber.Application.Exceptions;
using Tuber.Domain.Models;

namespace Application.UnitTests.Categories.Services;
internal class BankDeletionService_UnitTests
{
    private IBankDeletionService _sut;

    private Mock<IBankRepository> _mockBankRepo = new();

    private readonly Guid GOOD_BANK_ID = Guid.Parse("37ad872a-0304-4b10-abd3-3427dd90ec02");
    private readonly Guid MISSING_BANK_ID = Guid.Parse("b0a40ab9-74e6-47f3-964f-951b42fd28a3");

    [SetUp]
    public void Setup()
    {
        _mockBankRepo.Setup(x => x.GetById(It.Is<Guid>(x => x.Equals(GOOD_BANK_ID))))
           .Returns(new Bank
           {
               BankId = GOOD_BANK_ID,
           });
        _mockBankRepo.Setup(x => x.Delete(It.Is<Guid>(x => x.Equals(GOOD_BANK_ID))))
          .Returns(1);

        _mockBankRepo.Setup(x => x.GetById(It.Is<Guid>(x => x.Equals(MISSING_BANK_ID))))
           .Returns(new Bank());
        _mockBankRepo.Setup(x => x.Delete(It.Is<Guid>(x => x.Equals(MISSING_BANK_ID))))
          .Returns(0);

        _sut = new BankDeletionService(_mockBankRepo.Object);
    }


    [Test, Parallelizable]
    public void DeletingBank_ReturnsPayloadOf1AndNoException()
    {
        var serviceResult = _sut.Delete(GOOD_BANK_ID);

        serviceResult.IsSuccess.Should().BeTrue();
        serviceResult.HasFailed.Should().BeFalse();
        serviceResult.Exceptions.Count.Should().Be(0);
        serviceResult.Payload.Should().Be(1);
    }

    [Test, Parallelizable]
    public void DeletingBankThatDoesNotExist_ReturnsException()
    {
        var serviceResult = _sut.Delete(MISSING_BANK_ID);

        serviceResult.IsSuccess.Should().BeFalse();
        serviceResult.HasFailed.Should().BeTrue();
        serviceResult.Exceptions.Count.Should().Be(1);
        serviceResult.Exceptions.First().Should().BeOfType<EntityDoesNotExistException>();
        serviceResult.Payload.Should().Be(0);
    }
}
