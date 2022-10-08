using Tuber.Core.Exceptions;
using Tuber.Core.ValueObjects;

namespace Tuber.UnitTests.BLL.WeatherForecasts.Queries.GetWeatherForecast;

public class PositiveInteger_UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase(-1)]
    public void PositiveInteger_RejectsNegativeNumbers(int invalidValue)
    {
        Assert.Throws<InvalidPositiveIntegerException>(() => PositiveInt.From(invalidValue));
    }

    [Test]
    [TestCase(0)]
    [TestCase(1)]
    public void PositiveInteger_AcceptsPositiveAndZeroNumbers(int testValue)
    {
        Assert.DoesNotThrow(() => PositiveInt.From(testValue));
    }
}