using FluentAssertions;
using FluentValidation.Results;
using Tuber.API.Extensions;

namespace Tuber.UnitTests.API.Extensions;
internal class ValidationFailureExtensions_UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ValidationFailureExtensions_ValidationFailures_ReturnsCorrectBadRequestResponse()
    {
        var obj1 = new { value = "20220101" };
        var obj2 = new { value = 2 };

        var validationFailures = new List<ValidationFailure>
        {
            new ValidationFailure{ ErrorMessage = "errorMessage1", PropertyName="propertyName1",
                AttemptedValue=obj1, Severity=FluentValidation.Severity.Error },

            new ValidationFailure{ ErrorMessage = "errorMessage2", PropertyName="propertyName2",
                AttemptedValue=obj2, Severity=FluentValidation.Severity.Warning }
        };

        var sut = validationFailures.ToBadRequestResponse();

        sut.Length.Should().Be(2);

        var first = sut[0];
        first.ErrorMessage.Should().Be("errorMessage1");
        first.PropertyName.Should().Be("propertyName1");
        first.AttemptedValueSafe.Should().Be(obj1.ToString());
        first.SeverityDesc.Should().Be("Error");

        var second = sut[1];
        second.ErrorMessage.Should().Be("errorMessage2");
        second.PropertyName.Should().Be("propertyName2");
        second.AttemptedValueSafe.Should().Be(obj2.ToString());
        second.SeverityDesc.Should().Be("Warning");
    }
}
