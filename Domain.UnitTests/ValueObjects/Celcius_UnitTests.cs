using Tuber.Application.Exceptions;
using Tuber.Application.ValueObjects;

namespace Domain.UnitTests.ValueObjects;

public class Celcius_UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase(-273.16)]
    public void Celcius_RejectsValuesBelowAbsouteZero(double invalidValue)
    {
        Assert.Throws<TemperatureBelowAbsoluteZeroException>(() => Celcius.From(invalidValue));
    }

    [Test]
    [TestCase(-271.15)]
    [TestCase(0)]
    [TestCase(30)]
    [TestCase(double.MaxValue)]
    public void Celcius_AcceptsValuesAtOrAboveAbsoluteZero(double testValue)
    {
        Assert.DoesNotThrow(() => Celcius.From(testValue));
    }
}