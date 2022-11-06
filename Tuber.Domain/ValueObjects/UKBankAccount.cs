using System.Text.RegularExpressions;
using Tuber.Domain.Exceptions;
using ValueOf;

namespace Tuber.Domain.ValueObjects;

public class UKBankAccount : ValueOf<string, UKBankAccount>
{
    protected override void Validate()
    {
        if (Regex.IsMatch(Value, @"\d{8}"))
            return;
        throw new InvalidUKBankAccountException(Value);
    }

    //public static explicit operator string(UKBankAccount v)
    //{
    //    return v.Value;
    //}
}
