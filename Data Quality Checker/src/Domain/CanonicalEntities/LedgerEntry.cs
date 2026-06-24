// Ledger entry canonical data model for BC type ledger entries
namespace Data_Quality_Checker.Domain.CanonicalEntities
{
    public class LedgerEntry
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string AccountCode { get; set;}
        public string? Description { get; set; }
        public decimal? Amount { get; set; }
        public DateOnly? Date { get; set; }
        public string? DocumentNumber { get; set; }
        public string? DocumentType { get; set; }
        public required string? SourceId { get; set; }
    }
}