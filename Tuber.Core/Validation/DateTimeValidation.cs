namespace Tuber.Core.Validation;
public static class DateTimeValidation
{
    private const string MONTH_LIST = "JanFebMarAprMayJunJulAugSepOctNovDec";

    /// <summary>
    /// Get Year value from string according to the given date template
    /// </summary>
    /// <param name="dateValue"></param>
    /// <param name="dateTemplate"></param>
    /// <returns></returns>
    public static string GetYear(this string dateValue, string dateTemplate)
    {
        dateTemplate = dateTemplate.Trim().ToLower();

        string year;

        var i = dateTemplate.IndexOf("yyyy");
        if (i == -1)
        {
            i = dateTemplate.IndexOf("yy");
            if (i == -1)
                return "";
            else
                year = dateValue.Substring(i, 2);
        }
        else
        {
            year = dateValue.Substring(i, 4);
        }
        return year;
    }

    public static string GetMonth(this string dateValue, string dateTemplate)
    {
        dateTemplate = dateTemplate.Trim().ToLower();

        var i = dateTemplate.IndexOf("mmm");

        string month;
        if (i == -1)
        {
            i = dateTemplate.IndexOf("mm");
            if (i == -1)
                return "";
            else
                month = dateValue.Substring(i, 2);
        }
        else
        {
            month = dateValue.Substring(i, 3);
        }
        return month;
    }

    public static string GetDay(this string dateValue, string dateTemplate)
    {
        dateTemplate = dateTemplate.ToLower().Trim();
        string day;

        var i = dateTemplate.IndexOf("dd");
        if (i == -1)
            return "";

        day = dateValue.Substring(i, 2);
        return day;
    }

    /// <summary>
    /// Returns first non-digit character in dateTemplate
    /// </summary>
    /// <param name="dateValue"></param>
    /// <param name="dateTemplate"></param>
    /// <returns></returns>
    public static string GetSeperator(this string dateValue, string dateTemplate)
    {
        string seperator = "-";
        foreach (char ch in dateValue)
        {
            if (!char.IsDigit(ch))
            {
                seperator = ch.ToString();
                break;
            }
        }
        return seperator;
    }


    public static bool IsValidDate(this string dateValue, string dateTemplate)
    {
        dateValue = dateValue.Trim().ToLower();
        dateTemplate = dateTemplate.ToLower();

        if (dateValue.Length != dateTemplate.Length)
            return false;

        var year = dateValue.GetYear(dateTemplate);

        var month = dateValue.GetMonth(dateTemplate);

        var day = dateValue.GetDay(dateTemplate);

        var seperator = dateValue.GetSeperator(dateTemplate);

        if (!DateTime.TryParse($"{day}{seperator}{month}{seperator}{year}", out _))
            return false;

        return true;
    }

    public static string ToISO8601(this string validDate, string dateTemplate)
    {
        var day = validDate.GetDay(dateTemplate);
        if (day.Length < 2)
            day = "0" + day;

        var month = validDate.GetMonth(dateTemplate);
        if (month.Length == 3)
        {
            var i = MONTH_LIST.ToLower().IndexOf(month.ToLower()) + 3;
            month = (i / 3).ToString();
        }
        if (month.Length < 2)
            month = "0" + month;

        var year = validDate.GetYear(dateTemplate);
        if (year.Length == 2)
            year = "20" + year; //HACK: Change before the year 3000AD
        
        return $"{year}{month}{day}";
    }
}
