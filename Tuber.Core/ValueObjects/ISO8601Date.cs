using System.Text.RegularExpressions;
using Tuber.Core.Exceptions;
using ValueOf;

namespace Tuber.Core.ValueObjects;

public class ISO8601Date : ValueOf<string, ISO8601Date>
{
    protected override void Validate()
    {
        if (!Regex.IsMatch(Value, "^[0-9]{8}$"))
            throw new InvalidISO8601DateFormatException(Value);
        
        var year = int.Parse(Value[..4]);
        var month = int.Parse(Value.Substring(4, 2));
        var day = int.Parse(Value.Substring(6, 2));

        try
        {
            var testDate = new DateOnly(year, month, day);
        }
        catch (Exception)
        {
            throw new InvalidISO8601DateValueException(Value);
        }
    
    }

    public static implicit operator ISO8601Date(string v)
    {
       return v;
    }
}
