using AutoMapper;
using Tuber.API.Mappings;

namespace Tuber.UnitTests.API.Mappings;
public class WeatherForecastProfile_UnitTests
{
    [Test]
    public void WeatherForecastProfile_IsValid()
    {
        var config = new MapperConfiguration(cfg => cfg.AddProfile<WeatherForecastProfile>());
        config.AssertConfigurationIsValid();
    }
}
