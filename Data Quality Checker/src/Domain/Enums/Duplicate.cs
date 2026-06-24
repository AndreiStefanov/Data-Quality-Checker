//<Summary>
// Represents if a data entry has a duplicate or not.
//</Summary>

namespace Data_Quality_Checker.Domain.Enums
{
    public enum DuplicateState
    {
        Unknown, // Implicit value, data check has not been performed yet.
        Unique, // Data entry is unique.
        Duplicate // Data entry has duplicates.
    }
}
