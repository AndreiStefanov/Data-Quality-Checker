// System entity for idetifying correctly the generated report
namespace Data_Quality_Checker.Domain.SystemEntities
{
    public class Report
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid ValidationRunId { get; set; }
        public DateTime GeneratedAt { get; set; } = DateTime.UtcNow;
        public required string Summary { get; set; }
    }
}