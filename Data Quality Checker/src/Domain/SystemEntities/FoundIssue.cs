// System entity for the type of issue that is found when performing a data check
using Data_Quality_Checker.Domain.Enums;

namespace Data_Quality_Checker.Domain.SystemEntities
{
    public class Issue
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid ValidationRunId { get; set; }
        public required string RecordId { get; set; }
        public required string SourceId { get; set; }
        public required IssueType IssueType { get; set; }
        public Severity Severity { get; set; }
        public required string FieldName { get; set; }
        public string? ActualValue { get; set; }
        public required string Description { get; set; }
    }
}