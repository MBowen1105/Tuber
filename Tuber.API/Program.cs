using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tuber.API.Extensions;
using Tuber.BLL.Banks.Queries.GetBank;
using Tuber.Domain.Banks.GetBank;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

Tuber.API.DependencyInjection.AddDependencyInjection(builder.Services);
Tuber.BLL.DependencyInjection.AddDependencyInjection(builder.Services);
Tuber.DAL.DependencyInjection.AddDependencyInjection(builder.Services, builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.MapPut("/bank/get", async (GetBankAPIRequest APIRequest,
    [FromServices] IMediator mediator,
    [FromServices] IMapper mapper,
    [FromServices] IEnumerable<IValidator<GetBankAPIRequest>> validators) =>
{
    //  Validate incoming APIRequest.
    var context = new ValidationContext<GetBankAPIRequest>(APIRequest);
    var validationFailures = validators
        .Select(x => x.Validate(context))
        .SelectMany(x => x.Errors)
        .Where(x => x != null)
        .ToList();

    //  If the incoming API request has validation failures, convert them to the 
    //  BadRequest response and return a 400 Http Exception
    if (validationFailures.Any())
        return Results.BadRequest(validationFailures.ToBadRequestResponse());

    //  Map validated API request to query
    var query = mapper.Map<GetBankAPIRequest, GetBankQueryRequest>(APIRequest);

    // Call query handler. This first invokes the pipeline behaviour.
    var queryResponse = await mediator.Send(query);

    if (queryResponse.HasExceptions)
        return Results.BadRequest(queryResponse.Exceptions);

    //  Map Handler response to API Response and return.
    var apiResponse = mapper.Map<GetBankQueryResponse, GetBankAPIResponse>(queryResponse);

    return Results.Ok(apiResponse);
})
.WithName("GetBank");

app.Run();

