using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tuber.Application.InstitutionAccounts.Commands.InstitutionAccountUpdate;
using Tuber.Application.InstitutionAccounts.Queries.InstitutionAccountGetById;
using Tuber.Application.InstitutionAccounts.Queries.InstitutionAccountGetPaged;
using Tuber.Application.Exceptions;

namespace Tuber.API.InstitutionAccounts;

public static class InstitutionAccountEndpoints
{
    public static void CommandEndpoints(WebApplication app)
    {
        app.MapPut("/institutionaccount/update", async (InstitutionAccountUpdateAPIRequest APIRequest,
            [FromServices] IMediator mediator,
            [FromServices] IMapper mapper,
            [FromServices] IEnumerable<IValidator<InstitutionAccountUpdateAPIRequest>> validators) =>
        {
            //  Map validated API request to query
            var query = mapper.Map<InstitutionAccountUpdateAPIRequest, InstitutionAccountUpdateCommandRequest>(APIRequest);

            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(query);

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<InstitutionAccountUpdateCommandResponse, InstitutionAccountUpdateAPIResponse>(queryResponse);

            return Results.Accepted($"/institutionAccount/{apiResponse.InstitutionAccountId}", apiResponse);
        })
        .WithName("InstitutionAccountUpdate");
    }

    public static void QueryEndpoints(WebApplication app)
    {
        app.MapGet("/institutionAccount/get", async (int pageNumber, int pageSize,
        [FromServices] IMediator mediator,
        [FromServices] IMapper mapper) =>
        {
            if (pageNumber < 1)
                return Results.BadRequest(new InvalidPageNumberException(pageNumber));

            if (pageSize < 1)
                return Results.BadRequest(new InvalidPageSizeException(pageSize));

            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(new InstitutionAccountGetPagedQueryRequest
            {
                PageNumber = pageNumber,
                PageSize = pageSize
            });

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<InstitutionAccountGetPagedQueryResponse, InstitutionAccountGetPagedAPIResponse>(queryResponse);

            return Results.Ok(apiResponse);
        })
    .WithName("InstitutionAccountsGetPaged");


        app.MapGet("/institutionAccount/get/{id}", async (Guid institutionAccountId,
        [FromServices] IMediator mediator,
        [FromServices] IMapper mapper) =>
        {
            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(new InstitutionAccountGetByIdQueryRequest
            {
                InstitutionAccountId = institutionAccountId
            });

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<InstitutionAccountGetByIdQueryResponse, InstitutionAccountGetByIdAPIResponse>(queryResponse);

            return Results.Ok(apiResponse);
        })
            .WithName("InstitutionAccountGetById");
    }
}