using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tuber.BLL.BankAccounts.Queries.BankAccountGetById;
using Tuber.BLL.BankAccounts.Queries.BankAccountGetPaged;
using Tuber.Domain.Exceptions;

namespace Tuber.API.BankAccounts;

public static class BankAccountEndpoints
{
    public static void QueryEndpoints(WebApplication app)
    {
        app.MapGet("/bankAccount/get", async (int pageNumber, int pageSize,
        [FromServices] IMediator mediator,
        [FromServices] IMapper mapper) =>
    {
        if (pageNumber < 1)
            return Results.BadRequest(new InvalidPageNumberException(pageNumber));

        if (pageSize < 1)
            return Results.BadRequest(new InvalidPageSizeException(pageSize));

        // Call query handler. This first invokes the pipeline behaviour.
        var queryResponse = await mediator.Send(new BankAccountGetPagedQueryRequest
        {
            PageNumber = pageNumber,
            PageSize = pageSize
        });

        if (queryResponse.HasExceptions)
            return Results.BadRequest(queryResponse.Exceptions);

        //  Map Handler response to API Response and return.
        var apiResponse = mapper.Map<BankAccountGetPagedQueryResponse, BankAccountGetPagedAPIResponse>(queryResponse);

        return Results.Ok(apiResponse);
    })
    .WithName("GetBankAccounts");
    
        
    app.MapGet("/bankAccount/get/{id}", async(Guid id,
    [FromServices] IMediator mediator,
    [FromServices] IMapper mapper) =>
        {
            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(new BankAccountGetByIdQueryRequest
                {
                    BankAccountId = id
                });

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<BankAccountGetByIdQueryResponse, BankAccountGetByIdAPIResponse>(queryResponse);

            return Results.Ok(apiResponse);
        })
        .WithName("GetBankAccountById");
    }

}