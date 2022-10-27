﻿using Tuber.Core.ValueObjects;
using Tuber.Domain.API.WeatherForecasts.Domains;

namespace Tuber.BLL.WeatherForecasts.Queries.GetWeatherForecast;
public class GetWeatherForecastQueryResponse : QueryResponseBase
{
    public PositiveInt? ForecastCount { get; init; }
    public WeatherForecastDomain[]? Forecast { get; init; }
}
