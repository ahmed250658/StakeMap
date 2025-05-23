using StakeMap.Core.Feautres.Reports.Query.Dto;
using StakeMap.Infrastructure.Entities;



namespace StakeMap.Core.Mapping.Reports
{
    public partial class ReportProfile
    {
        public void GetAllReportQueryMapping()
        {
            CreateMap<Report, GetAllReportDto>();
        }
    }
}
