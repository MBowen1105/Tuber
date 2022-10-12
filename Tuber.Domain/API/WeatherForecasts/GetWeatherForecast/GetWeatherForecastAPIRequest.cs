﻿using System.ComponentModel.DataAnnotations;

namespace Tuber.Domain.API.WeatherForecasts.GetWeatherForecast
{
    public class GetWeatherForecastAPIRequest
    {
        [Required]
        public string FromDate { get; set; }=String.Empty;
        [Required]
        public int NumberOfDays { get; set; }
    }
}
