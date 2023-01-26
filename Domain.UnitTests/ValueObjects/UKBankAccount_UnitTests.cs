using Tuber.Application.Exceptions;
using Tuber.Application.ValueObjects;

namespace Domain.UnitTests.ValueObjects;

public class UKInstitutionAccount_UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test, Parallelizable]
    [TestCase("")]
    [TestCase("1234 5678")]
    [TestCase("1234567-")]
    public void UKInstitutionAccount_RejectsInvalidValues(string invalidValue)
    {
        Assert.Throws<InvalidUKInstitutionAccountException>(() => UKInstitutionAccount.From(invalidValue));
    }

    [Test, Parallelizable]
    [TestCase("12345678")]
    public void UKInstitutionAccount_AcceptsValidValues(string validValue)
    {
        Assert.DoesNotThrow(() => UKInstitutionAccount.From(validValue));
    }
}