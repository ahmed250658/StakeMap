using Microsoft.EntityFrameworkCore;
using StakeMap.Infrastructure.Base;
using StakeMap.Infrastructure.Context;
using StakeMap.Infrastructure.Entities;
using StakeMap.Infrastructure.Repository.Abstracts;

namespace StakeMap.Infrastructure.Repository.Implements
{
    public class DashboardMetricsRepository : GenericRepositoryAsync<DashboardMetrics>, IDashboardMetricsRepository
    {
        #region Fileds


        private DbSet<DashboardMetrics> _dashMatric;
        #endregion
        #region Constructor

        public DashboardMetricsRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dashMatric = dbContext.Set<DashboardMetrics>();
        }
        #endregion
    }
}
