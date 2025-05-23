using StakeMap.Infrastructure.Entities;

namespace StakeMap.Core.Service.Abstracts
{
    public interface IDashboardMetricService
    {
        public Task<List<DashboardMetrics>> GetAllDashboardMetrics();
    }
}
