namespace StakeMap.Infrastructure.Entities
{
    public class DashboardMetrics
    {
        public int Id { get; set; }
        public string MetricName { get; set; }
        public float MetricValue { get; set; }
        public float PreviousValue { get; set; }
        public float ChangePercentage { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
