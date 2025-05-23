namespace StakeMap.Core.Feautres.Reports.Query.Dto
{
    public class GetAllReportDto
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public string FilePath { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Category { get; set; }
    }
}
