using Tuber.Core.Exceptions;
using ValueOf;

namespace Tuber.Core.ValueObjects;

public class PositiveInt : ValueOf<int, PositiveInt>
{
    protected override void Validate()
    {
        if (Value < 1)
            throw new InvalidPositiveIntegerException(Value);
    }

    public static explicit operator int(PositiveInt v)
    {
        return v.Value;
    }
}
