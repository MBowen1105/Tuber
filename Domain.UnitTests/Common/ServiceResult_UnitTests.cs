using FluentAssertions;
using Tuber.Application.Common;
using Tuber.Domain.Models;

namespace Domain.UnitTests.Common;
internal class ServiceResult_UnitTests
{
    [SetUp]
    public void SetUp()
    {

    }

    [Test]
    public void WithJustAPayload_ReturnsIsSuccessWithNoExceptions()
    {
        var sut = new ServiceResult<Bank>(new Bank());

        sut.IsSuccess.Should().BeTrue();
        sut.HasFailed.Should().BeFalse();
        sut.Exceptions.Should().BeEquivalentTo(new List<Exception>());
        sut.Payload.Should().BeEquivalentTo(new Bank());
    }

    [Test]
    public void WithAPayloadAndOneException_ReturnsHasFailedOneExceptions()
    {
        var sut = new ServiceResult<Bank>(new Bank(), new Exception("Test"));

        sut.IsSuccess.Should().BeFalse();
        sut.HasFailed.Should().BeTrue();
        sut.Exceptions.Count.Should().Be(1);
        sut.Payload.Should().BeEquivalentTo(new Bank());
    }

    [Test]
    public void WithAPayloadAndMultipleExceptions_ReturnsHasFailedMultipleExceptions()
    {
        var sut = new ServiceResult<Bank>(new Bank(), new List<Exception>() {
            new Exception("Exception 1"),
            new Exception("Exception 2"),
            new Exception("Exception 3"),
        });

        sut.IsSuccess.Should().BeFalse();
        sut.HasFailed.Should().BeTrue();
        sut.Exceptions.Count.Should().Be(3);
        sut.Payload.Should().BeEquivalentTo(new Bank());
    }
}
