// System entity that defines the data validation check configuration created by the user
using Data_Quality_Checker.Domain.Enums;

namespace Data_Quality_Checker.Domain.SystemEntities
{
    public class ValidationConfiguration
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string Name { get; set; }
        public EntityType EntityType { get; set; }
        public required string EnabledRules { get; set; }
        public required string Thresholds { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}