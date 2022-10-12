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
    var queryRequest = mapper.Map<GetWeatherForecastAPIRequest, GetWeatherForecastQueryRequest>(APIRequest);
    
    var queryResponse = await mediator.Send(queryRequest);

    var APIResponse = mapper.Map<GetWeatherForecastQueryResponse, GetWeatherForecastAPIResponse>(queryResponse);

    return APIResponse is null
    ? Results.BadRequest(APIResponse)
    : Results.Ok(APIResponse);
})
.WithName("GetWeatherForecast");

app.Run();

