using System.Text.RegularExpressions;
using Tuber.Application.Exceptions;
using ValueOf;

namespace Tuber.Application.ValueObjects;

public class UKInstitutionAccount : ValueOf<string, UKInstitutionAccount>
{
    protected override void Validate()
    {
        if (Regex.IsMatch(Value, @"\d{8}"))
            return;
        throw new InvalidUKInstitutionAccountException(Value);
    }

    public static explicit operator string(UKInstitutionAccount v)
    {
        return $"{v.Value[..4]}-{v.Value.Substring(4,4)}";
    }
}
