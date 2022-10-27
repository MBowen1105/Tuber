using FluentValidation;
using Tuber.Domain.API.WeatherForecasts.GetWeatherForecast;

namespace Tuber.API.Validation;
public class GetWeatherForecastAPIRequestValidator : AbstractValidator<GetWeatherForecastAPIRequest>
{
	public GetWeatherForecastAPIRequestValidator()
	{
        RuleFor(x => x.FromDate)
            .NotEmpty()
            .Length(8);
        //TODO: Add ISO8601Date Custom validation

        RuleFor(x => x.NumberOfDays)
            .NotEmpty()
            .InclusiveBetween(1, 10)
                .WithMessage("Number of days must be between 1 and 10 only");

        
    }
}
