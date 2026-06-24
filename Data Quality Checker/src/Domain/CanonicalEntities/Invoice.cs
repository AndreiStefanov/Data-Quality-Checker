// Invoice canonical data model for BC type Invoice
namespace Data_Quality_Checker.Domain.CanonicalEntities
{
    public class Invoic
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required Guid CustomerId { get; set;}
        public required string InvoiceNumber  {get; set;}
        public DateOnly? IssueDate {get; set;}
        public DateOnly? DueDate {get; set;}
        public decimal? Amount {get; set;}
        public string? Currency {get; set;}
        public string? Status {get; set;}
        public required string? SourceId { get; set; } 
    }
}