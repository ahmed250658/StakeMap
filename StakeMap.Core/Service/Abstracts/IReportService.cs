using StakeMap.Infrastructure.Entities;

namespace StakeMap.Core.Service.Abstracts
{
    public interface IReportService
    {
        public Task<List<Report>> GetReportListAsync();
    }
}
