using FluentValidation;
using Tuber.BLL.WeatherForecasts.Queries.GetWeatherForecast;

namespace Tuber.BLL.Validation;
public class GetWeatherForecastQueryRequestValidator : AbstractValidator<GetWeatherForecastQueryRequest>
{
	public GetWeatherForecastQueryRequestValidator()
	{
        RuleFor(x => x.NumberOfDays.Value)
            .NotEmpty()
            .InclusiveBetween(1, 10)
                .WithMessage("Number of days must be between 1 and 10 only");

        RuleFor(x => x.FromDate.Value)
            .NotEmpty()
            .Length(8);
        //TODO: Add ISO8601Date Custom validation
    }
}
