using FluentValidation;
using Tuber.BLL.WeatherForecasts.Queries.GetWeatherForecast;

namespace Tuber.BLL.Validation;
public class GetWeatherForecastQueryRequestValidator : AbstractValidator<GetWeatherForecastQueryRequest>
{
	public GetWeatherForecastQueryRequestValidator()
	{
		RuleFor(x => x.FromDate)
			.NotEmpty();

		RuleFor(x => x.NumberOfDays)
			.GreaterThan(0);
    }
}
