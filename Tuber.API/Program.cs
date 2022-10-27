using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tuber.API.Extensions;
using Tuber.BLL.WeatherForecasts.Queries.GetWeatherForecast;
using Tuber.Domain.API.WeatherForecasts.GetWeatherForecast;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

Tuber.API.DependencyInjection.AddDependencyInjection(builder.Services);
Tuber.BLL.DependencyInjection.AddDependencyInjection(builder.Services);
Tuber.DAL.DependencyInjection.AddDependencyInjection(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.MapPut("/weatherforecast/get", async (GetWeatherForecastAPIRequest APIRequest,
    [FromServices] IMediator mediator,
    [FromServices] IMapper mapper,
    [FromServices] IEnumerable<IValidator<GetWeatherForecastAPIRequest>> validators) =>
{
    //  Validate incoming APIRequest.
    var context = new ValidationContext<GetWeatherForecastAPIRequest>(APIRequest);
    var validationFailures = validators
        .Select(x => x.Validate(context))
        .SelectMany(x => x.Errors)
        .Where(x => x != null)
        .ToList();

    if (validationFailures.Any())
        return Results.BadRequest(validationFailures.ToBadRequestResponse());

    //  Map validated API request to query
    var query = mapper.Map<GetWeatherForecastAPIRequest, GetWeatherForecastQueryRequest>(APIRequest);

    // Call query handler. This first invokes the pipeline behaviour.
    var queryResponse = await mediator.Send(query);

    if (queryResponse.HasExceptions)
        return Results.BadRequest(queryResponse.Exceptions);

    //  Map Handler response to API Response and return.
    var apiResponse = mapper.Map<GetWeatherForecastQueryResponse, GetWeatherForecastAPIResponse>(queryResponse);

    return Results.Ok(apiResponse);
})
.WithName("GetWeatherForecast");

app.Run();

