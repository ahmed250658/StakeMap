using StakeMap.Core.Feautres.DashBaordMatrics.Query.Dto;
using StakeMap.Infrastructure.Entities;

namespace StakeMap.Core.Mapping.Dashboard
{
    public partial class DashboardMastricsProfile
    {
        public void GetAllDashBoardMapping()
        {
            CreateMap<DashboardMetrics, GetAllDashboardMetricsDTO>();
        }
    }
}
