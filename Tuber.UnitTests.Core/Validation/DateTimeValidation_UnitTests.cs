using FluentAssertions;
using Tuber.Core.Validation;

namespace Tuber.UnitTests.Core.Validation;
internal class DateTimeValidation_UnitTests
{
    [Test]
    [TestCase("2022-03-21", true)]    //Valid date
    [TestCase("2022-03-00", false)]   //Bad Day
    [TestCase("2022-03-32", false)]   //Bad Day
    [TestCase("2022-00-21", false)]   //Bad Month
    [TestCase("2022-13-21", false)]   //bad Month
    [TestCase("2022-02-29", false)]   //Bad leap year
    [TestCase("2024-02-29", true)]    //Good Leap year
    [TestCase("2O22-03-21", false)]   //Bad character in Year
    [TestCase("2022/03/21", true)]    //Wrong sererator
    [TestCase("", false)]             //No date supplied
    public void CoOpDate_ValidatesCorrectly(string coOpDate, bool expectedResult)
    {
        var dateTemplate = "YYYY-MM-DD";

        var result = coOpDate.IsValidDate(dateTemplate);

        result.Should().Be(expectedResult);
    }


    [Test]
    [TestCase("21-Mar-2022", true)]    //Valid date
    [TestCase("00-Mar-2022", false)]   //Bad Day
    [TestCase("32-Mar-2022", false)]   //Bad Day
    [TestCase("21-Mas-2022", false)]   //Bad Month
    [TestCase("21-03-2022", false)]   //bad Month
    [TestCase("29-Feb-2022", false)]   //Bad leap year
    [TestCase("29-Feb-2024", true)]    //Good Leap year
    [TestCase("21-Mar-2O22", false)]   //Bad character in Year
    [TestCase("21/Mar/2022", true)]    //Wrong sererator
    [TestCase("", false)]             //No date supplied
    public void LloydsDate_ValidatesCorrectly(string lloydsDate, bool expectedResult)
    {
        var dateTemplate = "DD-MMM-YYYY";

        var result = lloydsDate.IsValidDate(dateTemplate);

        result.Should().Be(expectedResult);
    }


    [Test]
    [TestCase("20220321", true)]    //Valid date
    [TestCase("20220300", false)]   //Bad Day
    [TestCase("20220332", false)]   //Bad Day
    [TestCase("20220021", false)]   //Bad Month
    [TestCase("20221321", false)]   //bad Month
    [TestCase("20220229", false)]   //Bad leap year
    [TestCase("20240229", true)]    //Good Leap year
    [TestCase("2O220321", false)]   //Bad character in Year
    [TestCase("", false)]           //No date supplied
    public void ISO8601Dates_ValidatesCorrectly(string ISO8601Date, bool expectedResult)
    {
        var dateTemplate = "YYYYMMDD";

        var result = ISO8601Date.IsValidDate(dateTemplate);

        result.Should().Be(expectedResult);
    }

    [Test]
    [TestCase("11-May-1963", "DD-MMM-YYYY", "19630511")]
    [TestCase("11/05/1963", "DD/MM/YYYY", "19630511")]
    [TestCase("11-05-1963", "DD-MM-YYYY", "19630511")]
    public void ConvertToISO8601_WorksWithVariousDateTemplates(
        string testDate, string dateTemplate, string expectedISO8601Date)
    {
        var result = testDate.ToISO8601(dateTemplate);

        result.Should().Be(expectedISO8601Date);
    }
}
