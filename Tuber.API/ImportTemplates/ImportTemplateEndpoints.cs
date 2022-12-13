using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tuber.BLL.ImportTemplates.Queries.ImportTemplateGetById;
using Tuber.BLL.ImportTemplates.Queries.ImportTemplateGetPaged;
using Tuber.Domain.Exceptions;

namespace Tuber.API.ImportTemplates;

public static class ImportTemplateEndpoints
{
    public static void CommandEndpoints(WebApplication app)
    {        
    }

    public static void QueryEndpoints(WebApplication app)
    {
        app.MapGet("/importTemplate/get/{id}", async (Guid id,
            [FromServices] IMediator mediator,
            [FromServices] IMapper mapper) =>
        {
            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(new ImportTemplateGetByIdQueryRequest
            {
                ImportTemplateId = id
            });

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<ImportTemplateGetByIdQueryResponse, ImportTemplateGetByIdAPIResponse>(queryResponse);

            return Results.Ok(apiResponse);
        })
        .WithName("ImportTemplateGetById");


        app.MapGet("/importTemplate/get", async (int pageNumber, int pageSize,
                [FromServices] IMediator mediator,
                [FromServices] IMapper mapper) =>
        {
            if (pageNumber < 1)
                return Results.BadRequest(new InvalidPageNumberException(pageNumber));

            if (pageSize < 1)
                return Results.BadRequest(new InvalidPageSizeException(pageSize));

            // Call query handler. This first invokes the pipeline behaviour.
            var queryResponse = await mediator.Send(new ImportTemplateGetPagedQueryRequest
            {
                PageNumber = pageNumber,
                PageSize = pageSize
            });

            if (queryResponse.HasExceptions)
                return Results.BadRequest(queryResponse.Exceptions);

            //  Map Handler response to API Response and return.
            var apiResponse = mapper.Map<ImportTemplateGetPagedQueryResponse, ImportTemplateGetPagedAPIResponse>(queryResponse);

            return Results.Ok(apiResponse);
        })
            .WithName("ImportTemplatesGetPaged");


    }
}
