namespace StakeMap.Core.Feautres.DashBaordMatrics.Query.Dto
{
    public class GetAllDashboardMetricsDTO
    {
        public string MetricName { get; set; }
        public float MetricValue { get; set; }
        public float PreviousValue { get; set; }
        public float ChangePercentage { get; set; }
    }
}
