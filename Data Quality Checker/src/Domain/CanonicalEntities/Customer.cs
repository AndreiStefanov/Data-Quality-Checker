// Customer canonical data model for BC type Customer
namespace Data_Quality_Checker.Domain.CanonicalEntities
{
    public class Customer
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string? Name { get; set; }
        public string? CIF { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? County { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public required string? SourceId { get; set; }
    }
}
