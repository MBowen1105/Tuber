using AutoMapper;
using MediatR;
using Tuber.Application.Common.Interfaces;
using Tuber.Domain.Models;

namespace Tuber.Application.AppConfigs.Queries.AppConfigGet
{
    public class AppConfigGetQueryHandler : IRequestHandler<AppConfigGetQueryRequest, AppConfigGetQueryResponse>
    {
        private readonly IAppConfigRetrievalService _appConfigRetrievalService;
        private readonly IMapper _mapper;

        public AppConfigGetQueryHandler(IAppConfigRetrievalService appConfigRetrievalService, IMapper mapper)
        {
            _appConfigRetrievalService = appConfigRetrievalService;
            _mapper = mapper;
        }

        public Task<AppConfigGetQueryResponse> Handle(AppConfigGetQueryRequest request, CancellationToken cancellationToken)
        {
            var serviceResult = _appConfigRetrievalService.Get();

            var response = _mapper.Map<AppConfig, AppConfigGetQueryResponse>(serviceResult.Payload);

            response.Exceptions = serviceResult.Exceptions;

            return Task.FromResult(response);
        }
    }
}
