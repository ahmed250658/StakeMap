using Microsoft.EntityFrameworkCore;
using StakeMap.Infrastructure.Base;
using StakeMap.Infrastructure.Context;
using StakeMap.Infrastructure.Entities;
using StakeMap.Infrastructure.Repository.Abstracts;

namespace StakeMap.Infrastructure.Repository.Implements
{
    public class ReportRepository : GenericRepositoryAsync<Report>, IReportRepository
    {
        #region Fileds


        private DbSet<Report> _report;
        #endregion
        #region Constructor

        public ReportRepository(AppDbContext dbContext) : base(dbContext)
        {
            _report = dbContext.Set<Report>();
        }
        #endregion
    }

}
