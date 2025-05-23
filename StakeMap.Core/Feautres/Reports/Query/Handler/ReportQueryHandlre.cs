using AutoMapper;
using MediatR;
using Microsoft.Extensions.Localization;
using StakeMap.Core.Bases;
using StakeMap.Core.Feautres.Reports.Query.Dto;
using StakeMap.Core.Feautres.Reports.Query.Model;
using StakeMap.Core.Service.Abstracts;
using StakeMap.Core.Shared;

namespace StakeMap.Core.Feautres.Reports.Query.Handler
{
    public class ReportQueryHandlre : ResponseHandler,
                                   IRequestHandler<GetAllReportQuery, Response<List<GetAllReportDto>>>
    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResource> _stringLocalizer;
        private readonly IReportService _reportService;
        #endregion
        #region Constructor
        public ReportQueryHandlre(IStringLocalizer<SharedResource> stringLocalizer, IMapper mapper, IReportService reportService) : base(stringLocalizer)
        {
            _stringLocalizer = stringLocalizer;
            _mapper = mapper;
            _reportService = reportService;
        }
        #endregion
        #region Handle Function

        public async Task<Response<List<GetAllReportDto>>> Handle(GetAllReportQuery request, CancellationToken cancellationToken)
        {
            var reports = await _reportService.GetReportListAsync();

            if (reports == null) return NotFound<List<GetAllReportDto>>(_stringLocalizer[SharedREsourceKeys.NotFoundReport]);
            var ReportsMapping = _mapper.Map<List<GetAllReportDto>>(reports);

            var result = Success(ReportsMapping);
            result.Meta = new { Count = ReportsMapping.Count() };
            return result;
        }
        #endregion
    }
}
