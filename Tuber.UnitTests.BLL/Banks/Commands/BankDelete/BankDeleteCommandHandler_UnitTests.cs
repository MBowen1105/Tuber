using FluentAssertions;
using Moq;
using Tuber.BLL.Banks.Commands.BankDelete;
using Tuber.Core.Enums;
using Tuber.Domain.Common;
using Tuber.Domain.Exceptions;
using Tuber.Domain.Interfaces.BLL;
using Tuber.Domain.Models;

namespace Tuber.UnitTests.BLL.Banks.Commands.BankDelete;
internal class BankDeleteCommandHandler_UnitTests
{
    private BankDeleteCommandHandler _sut;

    private readonly Guid GoodId = Guid.Parse("40ba8e81-5b0f-4470-8719-51bd53597d89");
    private readonly Guid BadId = Guid.Parse("cd25992c-4a81-4f10-9e73-b741fc625099");

    private readonly Mock<IBankDeletionService> _mockBankDeletionService = new();


    [SetUp]
    public void Setup()
    {
        //  Calling Delete() with the "Good" ID returns a payload of 1 and no exceptions.
        _mockBankDeletionService.Setup(x => x.Delete(It.Is<Guid>(x => x.Equals(GoodId))))
           .Returns(new ServiceResult<int>(1));

        //  Calling Delete() with the "Bad" ID returns zero with an EntityDoesNotExistException
        _mockBankDeletionService.Setup(x => x.Delete(It.Is<Guid>(x => x.Equals(BadId))))
           .Returns(new ServiceResult<int>(0, new EntityDoesNotExistException(
               ExceptionDbOperation.Delete, Bank.FriendlyName, BadId)));

        _sut = new BankDeleteCommandHandler(_mockBankDeletionService.Object);
    }

    [Test]
    public void ExistingEntity_ReturnsDeletedCountOf1AndNoException()
    {
        var taskResponse = _sut.Handle(new BankDeleteCommandRequest { BankId = GoodId },
            new CancellationToken());

        taskResponse.Result.HasExceptions.Should().BeFalse();
        taskResponse.Result.Exceptions.Should().BeEmpty();

        taskResponse.Result.DeletedCount.Should().Be(1);
    }

    [Test]
    public void MissingingEntity_ReturnsDeletedCountOf0AndAEntityDoesNotExistException()
    {
        var taskResponse = _sut.Handle(new BankDeleteCommandRequest { BankId = BadId },
            new CancellationToken());

        taskResponse.Result.HasExceptions.Should().BeTrue();
        taskResponse.Result.Exceptions.Count.Should().Be(1);

        taskResponse.Result.Exceptions.First().Should().BeEquivalentTo(
            new EntityDoesNotExistException(ExceptionDbOperation.Delete,
                Bank.FriendlyName, BadId));

        taskResponse.Result.DeletedCount.Should().Be(0);
    }
}
