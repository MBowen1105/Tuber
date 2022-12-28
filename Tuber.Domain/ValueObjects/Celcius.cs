using Tuber.Application.Exceptions;
using ValueOf;

namespace Tuber.Application.ValueObjects;

public class Celcius : ValueOf<double, Celcius>
{
    private const double AbsoluteZeroInCelcius = -273.15;
    protected override void Validate()
    {
        if (Value < AbsoluteZeroInCelcius)
            throw new TemperatureBelowAbsoluteZeroException(Value);
    }

    public static explicit operator Double(Celcius v)
    {
        return v.Value;
    }
}
