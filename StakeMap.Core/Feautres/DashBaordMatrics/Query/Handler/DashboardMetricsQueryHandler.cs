using AutoMapper;
using MediatR;
using Microsoft.Extensions.Localization;
using StakeMap.Core.Bases;
using StakeMap.Core.Feautres.DashBaordMatrics.Query.Dto;
using StakeMap.Core.Feautres.DashBaordMatrics.Query.Model;
using StakeMap.Core.Service.Abstracts;
using StakeMap.Core.Shared;

namespace StakeMap.Core.Feautres.DashBaordMatrics.Query.Handler
{
    public class DashboardMetricsQueryHandler : ResponseHandler,
                                   IRequestHandler<GetAllDashboardMetricsQuery, Response<List<GetAllDashboardMetricsDTO>>>
    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResource> _stringLocalizer;
        private readonly IDashboardMetricService _dashboardMetricService;
        #endregion
        #region Constructor
        public DashboardMetricsQueryHandler(IStringLocalizer<SharedResource> stringLocalizer, IMapper mapper, IDashboardMetricService dashboardMetricService) : base(stringLocalizer)
        {
            _stringLocalizer = stringLocalizer;
            _mapper = mapper;
            _dashboardMetricService = dashboardMetricService;
        }
        #endregion
        #region Handle Function


        public async Task<Response<List<GetAllDashboardMetricsDTO>>> Handle(GetAllDashboardMetricsQuery request, CancellationToken cancellationToken)
        {
            var Dashs = await _dashboardMetricService.GetAllDashboardMetrics();
            if (Dashs == null) return NotFound<List<GetAllDashboardMetricsDTO>>();
            var DashboardMapping = _mapper.Map<List<GetAllDashboardMetricsDTO>>(Dashs);

            var result = Success(DashboardMapping);
            result.Meta = new { Count = DashboardMapping.Count() };
            return result;
        }
        #endregion
    }
}
