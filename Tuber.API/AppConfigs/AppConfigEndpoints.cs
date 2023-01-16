using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tuber.Application.AppConfigs.Queries.AppConfigGet;

namespace Tuber.API.AppConfigs;

public static class AppConfigEndpoints
{
    public static void CommandEndpoints(WebApplication app)
    {

        //app.MapPut("/appconfig/update", async (BankUpdateAPIRequest APIRequest,
        //    [FromServices] IMediator mediator,
        //    [FromServices] IMapper mapper,
        //    [FromServices] IEnumerable<IValidator<BankUpdateAPIRequest>> validators) =>
        //{
        //    //  Map validated API request to query
        //    var query = mapper.Map<BankUpdateAPIRequest, BankUpdateCommandRequest>(APIRequest);

        //    // Call query handler. This first invokes the pipeline behaviour.
        //    var queryResponse = await mediator.Send(query);

        //    if (queryResponse.HasExceptions)
        //        return Results.BadRequest(queryResponse.Exceptions);

        //    //  Map Handler response to API Response and return.
        //    var apiResponse = mapper.Map<BankUpdateCommandResponse, BankUpdateAPIResponse>(queryResponse);

        //    return Results.Accepted($"/bank/{apiResponse.Id}", apiResponse);
        //})
        //.WithName("AppConfigUpdate");
    }

    public static void QueryEndpoints(WebApplication app)
    {
        app.MapGet("/appconfig/get", async (
            [FromServices] IMediator mediator,
            [FromServices] IMapper mapper) =>
        {
            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(new AppConfigGetQueryRequest());

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<AppConfigGetQueryResponse, AppConfigGetAPIResponse>(queryResponse);

            return Results.Ok(apiResponse);
        })
        .WithName("AppConfigGet");
    }
}
