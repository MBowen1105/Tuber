using System.ComponentModel.DataAnnotations;
using Tuber.Core.ValueObjects;

namespace Tuber.Domain.API.WeatherForecasts.GetWeatherForecast
{
    public class GetWeatherForecastAPIRequest
    {
        [Required]
        public ISO8601Date? FromDate { get; set; }
        [Required]
        public int NumberOfDays { get; set; }
    }
}
