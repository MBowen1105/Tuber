using FluentValidation;
using Tuber.BLL.WeatherForecasts.Queries.GetWeatherForecast;

namespace Tuber.BLL.Validation;
public class GetWeatherForecastQueryRequestValidator : AbstractValidator<GetWeatherForecastQueryRequest>
{
	public GetWeatherForecastQueryRequestValidator()
	{
        RuleFor(x => x.FromDate.Value)
            .NotEmpty()
            .Length(8);

        RuleFor(x => x.NumberOfDays.Value)
            .NotEmpty()
            .InclusiveBetween(1, 10);

        
    }
}
