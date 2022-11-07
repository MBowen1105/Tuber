using FluentAssertions;
using FluentValidation;
using Tuber.API.Validators;
using Tuber.Domain.API.Banks.GetBank;

namespace Tuber.UnitTests.API.Validators;
internal class GetBankAPIRequestValidator_UnitTests
{
    private GetBankPagedAPIRequestValidator _sut;

    [SetUp]
    public void SetUp()
    {
        _sut = new GetBankPagedAPIRequestValidator();
    }

    [Test]
    public void GetBankAPIRequestValidator_ValidPayload_ReturnsValidResult()
    {
        var payload = new GetBankPagedAPIRequest()
        {
            PageNumber = 1,
            PageSize = 10,
        };

        var result = _sut.Validate(payload);

        result.IsValid.Should().Be(true);
        result.Errors.Should().BeEmpty();
    }

    [Test]
    public void GetBankAPIRequestValidator_NegativePageNumber_ThrowsOneException()
    {
        var payload = new GetBankPagedAPIRequest()
        {
            PageNumber = -1,
            PageSize = 10,
        };

        var result = _sut.Validate(payload);

        result.IsValid.Should().Be(false);
        result.Errors.Should().HaveCount(1);
        result.Errors[0].ErrorMessage.Should().Be("'Page Number' must be greater than or equal to '1'.");
    }

    [Test]
    public void GetBankAPIRequestValidator_ZeroPageNumber_ThrowsTwoExceptions()
    {
        var payload = new GetBankPagedAPIRequest()
        {
            PageNumber = 0,
            PageSize = 10,
        };

        var result = _sut.Validate(payload);

        result.IsValid.Should().Be(false);
        result.Errors.Should().HaveCount(2);
        result.Errors[0].ErrorMessage.Should().Be("'Page Number' must not be empty.");
        result.Errors[1].ErrorMessage.Should().Be("'Page Number' must be greater than or equal to '1'.");
    }

    [Test]
    public void GetBankAPIRequestValidator_ZeroPageSize_ThrowException()
    {
        var payload = new GetBankPagedAPIRequest()
        {
            PageNumber = 1,
            PageSize = 0,
        };

        var result = _sut.Validate(payload);

        result.IsValid.Should().Be(false);
        result.Errors.Should().HaveCount(2);
        result.Errors[0].ErrorMessage.Should().Be("'Page Size' must not be empty.");
        result.Errors[1].ErrorMessage.Should().Be("'Page Size' must be greater than or equal to '1'.");
    }
}
