namespace StakeMap.Infrastructure.Entities
{
    public class Report
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string FilePath { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string Category { get; set; }
    }
}
