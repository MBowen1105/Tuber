using Tuber.Application.Exceptions;
using Tuber.Application.ValueObjects;

namespace Domain.UnitTests.ValueObjects;

public class UKBankAccount_UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test, Parallelizable]
    [TestCase("")]
    [TestCase("1234 5678")]
    [TestCase("1234567-")]
    public void UKBankAccount_RejectsInvalidValues(string invalidValue)
    {
        Assert.Throws<InvalidUKBankAccountException>(() => UKBankAccount.From(invalidValue));
    }

    [Test, Parallelizable]
    [TestCase("12345678")]
    public void UKBankAccount_AcceptsValidValues(string validValue)
    {
        Assert.DoesNotThrow(() => UKBankAccount.From(validValue));
    }
}