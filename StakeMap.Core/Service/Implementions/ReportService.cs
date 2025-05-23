using Microsoft.EntityFrameworkCore;
using StakeMap.Core.Service.Abstracts;
using StakeMap.Infrastructure.Entities;
using StakeMap.Infrastructure.Repository.Abstracts;

namespace StakeMap.Core.Service.Implementions
{
    public class ReportService : IReportService
    {
        #region Fields
        private readonly IReportRepository _reportRepository;
        #endregion

        #region Constructure
        public ReportService(IReportRepository reportRepository)
        {
            _reportRepository = reportRepository;
        }
        #endregion

        #region Handle Function
        public async Task<List<Report>> GetReportListAsync()
        {
            return await _reportRepository.GetTableNoTracking().OrderBy(s => s.CreatedAt).ToListAsync();
        }
        #endregion

    }
}
