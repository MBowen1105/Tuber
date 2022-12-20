using FluentAssertions;
using Moq;
using Tuber.BLL.BankAccounts.Commands.BankAccountDelete;
using Tuber.Core.Enums;
using Tuber.Domain.Common;
using Tuber.Domain.Exceptions;
using Tuber.BLL.Interfaces;
using Tuber.Domain.Models;

namespace Tuber.UnitTests.BLL.BankAccounts.Commands.BankAccountDelete;
internal class BankAccountDeleteCommandHandler_UnitTests
{
    private BankAccountDeleteCommandHandler _sut;

    private readonly Guid GoodId = Guid.Parse("40ba8e81-5b0f-4470-8719-51bd53597d89");
    private readonly Guid BadId = Guid.Parse("cd25992c-4a81-4f10-9e73-b741fc625099");

    private readonly Mock<IBankAccountDeletionService> _mockBankAccountDeletionService = new();


    [SetUp]
    public void Setup()
    {
        //  Calling Delete() with the "Good" ID returns a payload of 1 and no exceptions.
        _mockBankAccountDeletionService.Setup(x => x.Delete(It.Is<Guid>(x => x.Equals(GoodId))))
           .Returns(new ServiceResult<int>(1));

        //  Calling Delete() with the "Bad" ID returns zero with an EntityDoesNotExistException
        _mockBankAccountDeletionService.Setup(x => x.Delete(It.Is<Guid>(x => x.Equals(BadId))))
           .Returns(new ServiceResult<int>(0, new EntityDoesNotExistException(
               ExceptionDbOperation.Delete, BankAccount.FriendlyName, BadId)));

        _sut = new BankAccountDeleteCommandHandler(_mockBankAccountDeletionService.Object);
    }

    [Test]
    public void ExistingEntity_ReturnsDeletedCountOf1AndNoException()
    {
        var taskResponse = _sut.Handle(new BankAccountDeleteCommandRequest { BankAccountId = GoodId },
            new CancellationToken());

        taskResponse.Result.HasExceptions.Should().BeFalse();
        taskResponse.Result.Exceptions.Should().BeEmpty();

        taskResponse.Result.DeletedCount.Should().Be(1);
    }

    [Test]
    public void MissingingEntity_ReturnsDeletedCountOf0AndAEntityDoesNotExistException()
    {
        var taskResponse = _sut.Handle(new BankAccountDeleteCommandRequest { BankAccountId = BadId },
            new CancellationToken());

        taskResponse.Result.HasExceptions.Should().BeTrue();
        taskResponse.Result.Exceptions.Count.Should().Be(1);

        taskResponse.Result.Exceptions.First().Should().BeEquivalentTo(
            new EntityDoesNotExistException(ExceptionDbOperation.Delete,
                BankAccount.FriendlyName, BadId));

        taskResponse.Result.DeletedCount.Should().Be(0);
    }
}
