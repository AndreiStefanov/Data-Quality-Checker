// Used for determining for which type of validation a run was executed
// Ex: Customer, Invoice, LedgerEntry
namespace Data_Quality_Checker.Domain.Enums
{
    public enum EntityType
    {
        Customer,
        Invoice,
        LedgerEntry
    }
}