using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tuber.BLL.Banks.Commands.AddBank;
using Tuber.BLL.Banks.Commands.DeleteBank;
using Tuber.BLL.Banks.Commands.UpdateBank;
using Tuber.BLL.Banks.Queries.GetBankById;
using Tuber.BLL.Banks.Queries.GetBankPaged;
using Tuber.BLL.Extensions;
using Tuber.Domain.Exceptions;

namespace Tuber.API.Banks;

public static class BankExtensions
{
    public static void CommandEndpoints(WebApplication app)
    {
        app.MapPut("/bank/add", async (AddBankAPIRequest APIRequest,
            [FromServices] IMediator mediator,
            [FromServices] IMapper mapper,
            [FromServices] IEnumerable<IValidator<AddBankAPIRequest>> validators) =>
        {
            //  Map API request to query
            var query = mapper.Map<AddBankAPIRequest, AddBankCommandRequest>(APIRequest);

            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(query);

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<AddBankCommandResponse, AddBankAPIResponse>(queryResponse);

            return Results.Created($"/bank/{apiResponse.Id}", apiResponse);
        })
        .WithName("AddBank");


        app.MapPut("/bank/update", async (UpdateBankAPIRequest APIRequest,
            [FromServices] IMediator mediator,
            [FromServices] IMapper mapper,
            [FromServices] IEnumerable<IValidator<UpdateBankAPIRequest>> validators) =>
        {
            //  Map validated API request to query
            var query = mapper.Map<UpdateBankAPIRequest, UpdateBankCommandRequest>(APIRequest);

            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(query);

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<UpdateBankCommandResponse, UpdateBankAPIResponse>(queryResponse);

            return Results.Accepted($"/bank/{apiResponse.Id}", apiResponse);
        })
        .WithName("UpdateBank");



        app.MapDelete("/bank/delete/{id}", async (Guid id,
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
        .WithName("GetBanks");


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
}
