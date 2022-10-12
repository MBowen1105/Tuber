using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
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
    [FromServices] IMapper mapper) =>
{
    //  Validate incoming API Request.
    var validationFailures = APIRequest.GetValidationFailures();
    if (validationFailures.Any())
        return Results.BadRequest(validationFailures);

    //  Map validated API request to appropriate query request and call handler.
    var queryResponse = await mediator.Send(
        mapper.Map<GetWeatherForecastAPIRequest, GetWeatherForecastQueryRequest>(APIRequest));

    if (queryResponse.Errors.Any())
        return Results.BadRequest(queryResponse.Errors);

    //  Map Handler response to API Response and return.
    return Results.Ok(
        mapper.Map<GetWeatherForecastQueryResponse, GetWeatherForecastAPIResponse>(queryResponse));
})
.WithName("GetWeatherForecast");

app.Run();

