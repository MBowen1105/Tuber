using System.ComponentModel.DataAnnotations;
using Tuber.Core.ValueObjects;

namespace Tuber.Domain.API.WeatherForecasts.GetWeatherForecast
{
    public class GetWeatherForecastAPIRequest
    {
        [Required]
        public string? FromDate { get; init; }

        [Required]
        public int NumberOfDays { get; init; }
    }

    public static class GetWeatherForecastAPIRequestExtensions
    {
        public static List<string> GetValidationFailures(this GetWeatherForecastAPIRequest request)
        {
            string sut = String.Empty;
            List<string> validationFailures = new();

            try
            {
                sut = "FromDate";
                ISO8601Date.From(request.FromDate);
            }
            catch (Exception ex)
            {
                validationFailures.Add($"{sut}: {ex.Message}");
            }

            try
            {
                sut = "NumberOfDays";
                PositiveInt.From(request.NumberOfDays);
            }
            catch (Exception ex)
            {
                validationFailures.Add($"{sut}: {ex.Message}");
            }

            return validationFailures;
        }

    }
}
