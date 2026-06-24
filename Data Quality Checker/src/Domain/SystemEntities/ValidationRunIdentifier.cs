// System entity for the identifying the instance of the validation check that occured
using Data_Quality_Checker.Domain.Enums;
using Microsoft.CodeAnalysis.Options;

namespace Data_Quality_Checker.Domain.SystemEntities
{
    public class ValidationRunIdentifier
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid ConfigurationId { get; set; }
        public DateTime StartedAt { get; set; } = DateTime.UtcNow;
        public DateTime? CompletedAt { get; set; } 
        public ValidationRunStatus Status { get; set; } = ValidationRunStatus.Running;
        public int TotalRecords { get; set; }
        public EntityType EntityType { get; set; }
    }
}