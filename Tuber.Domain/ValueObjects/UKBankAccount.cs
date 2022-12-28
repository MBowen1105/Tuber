using System.Text.RegularExpressions;
using Tuber.Application.Exceptions;
using ValueOf;

namespace Tuber.Application.ValueObjects;

public class UKBankAccount : ValueOf<string, UKBankAccount>
{
    protected override void Validate()
    {
        if (Regex.IsMatch(Value, @"\d{8}"))
            return;
        throw new InvalidUKBankAccountException(Value);
    }

    public static explicit operator string(UKBankAccount v)
    {
        return $"{v.Value[..4]}-{v.Value.Substring(4,4)}";
    }
}
