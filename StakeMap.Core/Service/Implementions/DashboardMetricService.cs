using Microsoft.EntityFrameworkCore;
using StakeMap.Core.Service.Abstracts;
using StakeMap.Infrastructure.Entities;
using StakeMap.Infrastructure.Repository.Abstracts;

namespace StakeMap.Core.Service.Implementions
{
    public class DashboardMetricService : IDashboardMetricService
    {
        #region Fields
        private readonly IDashboardMetricsRepository _dashmt;
        #endregion

        #region Constructure
        public DashboardMetricService(IDashboardMetricsRepository dashmt)
        {
            _dashmt = dashmt;
        }

        #endregion

        #region Handle Function
        public async Task<List<DashboardMetrics>> GetAllDashboardMetrics()
        {
            return await _dashmt.GetTableNoTracking().ToListAsync();
        }
        #endregion
    }
}
