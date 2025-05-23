using MediatR;
using StakeMap.Core.Bases;
using StakeMap.Core.Feautres.DashBaordMatrics.Query.Dto;

namespace StakeMap.Core.Feautres.DashBaordMatrics.Query.Model
{
    public class GetAllDashboardMetricsQuery : IRequest<Response<List<GetAllDashboardMetricsDTO>>>
    {
    }
}
