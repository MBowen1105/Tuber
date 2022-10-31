using Tuber.Core.Exceptions;
using Tuber.Core.ValueObjects;

namespace Tuber.UnitTests.BLL.Banks.Queries.GetBank;

public class PositiveInteger_UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase(0)]
    [TestCase(-1)]
    public void PositiveInteger_RejectsZeroAndNegativeNumbers(int invalidValue)
    {
        Assert.Throws<InvalidPositiveIntegerException>(() => PositiveInt.From(invalidValue));
    }

    [Test]
    [TestCase(1)]
    [TestCase(int.MaxValue)]
    public void PositiveInteger_AcceptsPositiveNumbers(int testValue)
    {
        Assert.DoesNotThrow(() => PositiveInt.From(testValue));
    }
}