using MediatR;
using StakeMap.Core.Bases;
using StakeMap.Core.Feautres.Reports.Query.Dto;

namespace StakeMap.Core.Feautres.Reports.Query.Model
{
    public class GetAllReportQuery : IRequest<Response<List<GetAllReportDto>>>
    {
    }
}
