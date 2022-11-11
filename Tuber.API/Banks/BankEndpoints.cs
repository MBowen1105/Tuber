using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tuber.Domain.Exceptions;
using Tuber.BLL.Banks.Queries.GetBankPaged;
using Tuber.BLL.Banks.Queries.GetBankById;
using Tuber.BLL.Extensions;
using Tuber.BLL.Banks.Commands.PutBank;
using Tuber.BLL.Banks.Commands.DeleteBank;

namespace Tuber.API.Banks;

public static class BankEndpoints
{
    public static void QueryEndpoints(WebApplication app)
    {
        app.MapGet("/bank/get", async (int pageNumber, int pageSize,
            [FromServices] IMediator mediator,
            [FromServices] IMapper mapper) =>
        {
            if (pageNumber < 1)
                return Results.BadRequest(new InvalidPageNumberException(pageNumber));

            if (pageSize < 1)
                return Results.BadRequest(new InvalidPageSizeException(pageSize));

            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(new GetBankPagedQueryRequest
            {
                PageNumber = pageNumber,
                PageSize = pageSize
            });

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<GetBankPagedQueryResponse, GetBankPagedAPIResponse>(queryResponse);

            return Results.Ok(apiResponse);
        })
        .WithName("GetBank");

        app.MapGet("/bank/get/{id}", async (Guid id,
            [FromServices] IMediator mediator,
            [FromServices] IMapper mapper) =>
        {
            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(new GetBankByIdQueryRequest
            {
                BankId = id
            });

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<GetBankByIdQueryResponse, GetBankByIdAPIResponse>(queryResponse);

            return Results.Ok(apiResponse);
        })
        .WithName("GetBankById");
    }

    public static void CommandEndpoints(WebApplication app)
    {
        app.MapPut("/bank/put", async (PutBankAPIRequest APIRequest,
            [FromServices] IMediator mediator,
            [FromServices] IMapper mapper,
            [FromServices] IEnumerable<IValidator<PutBankAPIRequest>> validators) =>
        {
            //  Validate incoming API Request.
            var context = new ValidationContext<PutBankAPIRequest>(APIRequest);
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
            var query = mapper.Map<PutBankAPIRequest, PutBankCommandRequest>(APIRequest);

            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(query);

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<PutBankCommandResponse, PutBankAPIResponse>(queryResponse);

            return Results.Created($"/bank/{apiResponse.Id}", apiResponse);
        })
        .WithName("PutBank");

        app.MapDelete("/bank/delete", async (Guid id,
            [FromServices] IMediator mediator) =>
        {
            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(new DeleteBankCommandRequest
            {
                Id = id,
            });

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            return Results.NoContent();
        })
        .WithName("DeleteBank");
    }
}
