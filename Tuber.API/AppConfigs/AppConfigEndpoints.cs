using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tuber.Application.AppConfigs.Commands.AppConfigUpdate;
using Tuber.Application.AppConfigs.Queries.AppConfigGet;

namespace Tuber.API.AppConfigs;

public static class AppConfigEndpoints
{
    public static void CommandEndpoints(WebApplication app)
    {
        app.MapPut("/appconfig/update", async (AppConfigUpdateAPIRequest APIRequest,
            [FromServices] IMediator mediator,
            [FromServices] IMapper mapper,
            [FromServices] IEnumerable<IValidator<AppConfigUpdateAPIRequest>> validators) =>
        {
            //  Map validated API request to query
            var query = mapper.Map<AppConfigUpdateAPIRequest, AppConfigUpdateCommandRequest>(APIRequest);

            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(query);

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<AppConfigUpdateCommandResponse, AppConfigUpdateAPIResponse>(queryResponse);

            return Results.Accepted($"/AppConfig/{apiResponse.AppConfigId}", apiResponse);
        })
        .WithName("AppConfigUpdate");
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
